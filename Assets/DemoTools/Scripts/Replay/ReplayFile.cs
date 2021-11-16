using UnityEngine;
using System.IO;

using Timeline = FloatArrayIterator<ReplayFrame>;

public static class ReplayFile {
	public const string FolderName = "Replays/";
	public const string ReplayFileExt = ".replay";

	private static string GetReplayProjectPath(string name) {
        return Path.Combine (Path.Combine (Application.streamingAssetsPath, FolderName), name + ReplayFileExt);
	}

    private static string GetReplayExternalPath(string name) {
        return Path.Combine(Path.Combine(Application.persistentDataPath, FolderName), name + ReplayFileExt);
    }

    public static void Save(string replayName, Timeline.Entry[] data) {
		if (!string.IsNullOrEmpty(replayName) && data != null && data.Length > 0) {
            #if UNITY_EDITOR
			var path = GetReplayProjectPath(replayName);
            #else
            var path = GetReplayExternalPath(replayName);
            #endif
            var directory = Path.GetDirectoryName(path);

            if (!Directory.Exists(directory)) {
                Directory.CreateDirectory(directory);
            }

			using (var writer = new BinaryWriter (File.Open (path, FileMode.Create))) {
				writer.Write(data.Length);

				for (int i = 0; i < data.Length; i++) {
					var entry = data[i];
					var frame = entry.Value;

					writer.Write(entry.Key);
                    writer.WriteReplayFrame(frame);
                }
			}
		}
	}

	public static Timeline.Entry[] Load(string replayName) {
		Timeline.Entry[] data = null;

		var bytes = ReadReplayData(replayName);

		if (bytes == null) {
			Debug.LogError("Replay not found.");
			return null;
		}

		var memoryStream = new MemoryStream(bytes);

		using (var reader = new BinaryReader(memoryStream)) {
			int lenght = reader.ReadInt32();
			data = new Timeline.Entry[lenght];

			for (int i = 0; i < lenght; i++) {
				var key = reader.ReadSingle();
                var frame = reader.ReadReplayFrame();

                data[i] = new Timeline.Entry(key, frame);
			}
		}

		return data;
	}

    private static byte[] ReadReplayData(string replayName) {
        var projectPath = GetReplayProjectPath(replayName);

        if (File.Exists(projectPath)) {
            return File.ReadAllBytes(projectPath);
        }

        var externalPath = GetReplayExternalPath(replayName);

        if (File.Exists(externalPath)) {
            return File.ReadAllBytes(externalPath);
        }

        return null;
    }

    private static void WriteReplayFrame(this BinaryWriter writer, ReplayFrame frame) {
        writer.Write((byte)frame.Action);
        writer.WriteVector3(frame.Position);
        writer.WriteVector3(frame.Rotation.eulerAngles);
    }

    private static ReplayFrame ReadReplayFrame(this BinaryReader reader) {
        var action = (ReplayFrameAction)reader.ReadByte();
        var position = ReadVector3(reader);  //reader.ReadVector3();
        var rotation = Quaternion.Euler(ReadVector3(reader));

        return new ReplayFrame(position, rotation, action);
    }
    
    private static void WriteVector3(this BinaryWriter writer, Vector3 value) {
        writer.Write(value.x);
        writer.Write(value.y);
        writer.Write(value.z);
    }

    private static Vector3 ReadVector3(this BinaryReader reader) {
        return new Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
    }

    private static string ReadString(this BinaryReader reader) {
        var length = reader.ReadInt32();

        if (length > 0) {
            var data = new byte[length];
            if (reader.Read(data, 0, length) == length) {
                return System.Text.Encoding.UTF8.GetString(data);
            }
        }

        return string.Empty;
    }

    private static void WriteString(this BinaryWriter writer, string value) {
        if (string.IsNullOrEmpty(value)) {
            writer.Write(0);
        } else {
            var data = System.Text.Encoding.UTF8.GetBytes(value);

            if (data.Length > 0) {
                writer.Write(data.Length);
                writer.Write(data, 0, data.Length);
            }
        }
    }
}
