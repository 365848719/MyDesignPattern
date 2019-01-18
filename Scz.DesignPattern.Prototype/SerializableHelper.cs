using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/// <summary> 
/// 序列化和反序列化辅助类 
/// </summary> 
public class SerializableHelper
{
    public static string Serializable(object target)
    {
        using (MemoryStream stream = new MemoryStream())
        {
            new BinaryFormatter().Serialize(stream, target);

            return Convert.ToBase64String(stream.ToArray());
        }
    }

    public static object Derializable(string target)
    {
        byte[] targetArray = Convert.FromBase64String(target);

        using (MemoryStream stream = new MemoryStream(targetArray))
        {
            return new BinaryFormatter().Deserialize(stream);
        }
    }

    public static T Derializable<T>(string target)
    {
        return (T)Derializable(target);
    }
}
