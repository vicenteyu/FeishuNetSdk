using FeishuNetSdk;
using FeishuNetSdk.Im.Dtos;
using System.Text.Json;
using System.Text.Json.Serialization;

public partial class Program
{
    static JsonSerializerOptions option = new()
    {
        PropertyNameCaseInsensitive = false,
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };
    private static void Main(string[] args)
    {


        var element = new StandardIconElement("check_outlined");
        var a = JsonSerializer.Serialize(element, option);
        Console.WriteLine(a);

        var s = """            
            {"tag":"standard_icon","token":null,"color":null}            
            """;
        var b = JsonSerializer.Deserialize<IconElement>(s);

        Console.WriteLine(b);

        var div = new DivElement().SetText(new PlainTextElement("新文本")).SetIcon(new StandardIconElement("check_outlined"));

        Console.WriteLine(JsonSerializer.Serialize(div));

        object[] elements = [div,
    new FormButtonElement(Name: Guid.NewGuid().ToString(), Text: new($"xxx1{DateTime.Now}"), Behaviors: [new CallbackBehaviors(new { key = "CallbackBehaviors" })])];

        var c = JsonSerializer.Serialize(elements);
        Console.WriteLine(c);

        Console.ReadKey();
    }
}