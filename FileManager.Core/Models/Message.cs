namespace FileManager.Core.Models;

public class Message
{
    public MessageType Type { get; set; }

    public object? Value { get; set; }
}