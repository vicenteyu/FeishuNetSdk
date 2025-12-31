// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="DtoExtensions.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
using System.Text.Json;

namespace FeishuNetSdk.Extensions;

/// <summary>
/// DTO扩展方法
/// </summary>
public static class DtoExtensions
{
    static readonly JsonSerializerOptions options = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    /// <summary>
    /// 设置控件的方法
    /// </summary>
    /// <param name="Dto">创建审批实例 请求体</param>
    /// <param name="FormControls">
    /// <para>支持的控件明细参见：Approval.Dtos 命名空间下：</para>
    /// <list type="bullet">
    /// <item>InputFormControl</item>
    /// <item>TextareaFormControl</item>
    /// <item>NumberFormControl</item>
    /// <item>AmountFormControl</item>
    /// <item>DateFormControl</item>
    /// <item>DateIntervalFormControl</item>
    /// <item>FormulaFormControl</item>
    /// <item>AttachmentFormControl</item>
    /// <item>ImageFormControl</item>
    /// <item>ContactFormControl</item>
    /// <item>ConnectFormControl</item>
    /// <item>RadioFormControl</item>
    /// <item>CheckboxFormControl</item>
    /// <item>FieldListFormControl</item>
    /// <item>DepartmentFormControl</item>
    /// <item>TelephoneFormControl</item>
    /// <item>ShiftGroupFormControl</item>
    /// </list>
    /// </param>
    public static Approval.PostApprovalV4InstancesBodyDto SetFormControls(this Approval.PostApprovalV4InstancesBodyDto Dto,
        object[] FormControls)
    {
        Dto.Form = JsonSerializer.Serialize(FormControls);

        return Dto;
    }

    /// <summary>
    /// 获取序列化的控件信息
    /// </summary>
    /// <param name="Dto">查看指定审批定义 响应体</param>
    /// <returns>序列化的控件数组</returns>
    public static Approval.Dtos.FormControlDto[]? GetFormControls(this Approval.GetApprovalV4ApprovalsByApprovalCodeResponseDto? Dto)
            => Dto is null ? null
                : JsonSerializer.Deserialize<Approval.Dtos.FormControlDto[]>(Dto.Form);

    /// <summary>
    /// 设置消息卡片内容
    /// </summary>
    /// <param name="Dto">延时更新消息卡片 请求体</param>
    /// <param name="CardObject">消息卡片对象，包括以下：
    /// <list type="bullet">
    /// <item>ElementsCardWithOpenIds</item>
    /// <item>TemplateCardWithOpenIds</item>
    /// </list>
    /// </param>
    public static Im.Spec.PostInteractiveV1CardUpdateBodyDto SetCardObject(this Im.Spec.PostInteractiveV1CardUpdateBodyDto Dto,
        Im.Dtos.IHasOpenIds CardObject)
    {
        Dto.Card = CardObject;

        return Dto;
    }

    /// <summary>
    /// 设置消息卡片内容
    /// </summary>
    /// <param name="Dto">更新应用发送的消息卡片 请求体</param>
    /// <param name="CardObject">
    /// <inheritdoc cref="Im.Dtos.MessageCard" path="/summary"/>
    /// </param>
    public static Im.PatchImV1MessagesByMessageIdBodyDto SetCardObject(this Im.PatchImV1MessagesByMessageIdBodyDto Dto,
        Im.Dtos.MessageCard CardObject)
    {
        Dto.Content = JsonSerializer.Serialize(CardObject, CardObject.GetType(), options);

        return Dto;
    }

    /// <summary>
    /// 设置消息类型及内容
    /// </summary>
    /// <param name="Dto">发送仅特定人可见的消息卡片 请求体</param>
    /// <param name="CardObject">
    /// <inheritdoc cref="Im.Dtos.MessageCard" path="/summary"/>
    /// </param>
    public static Im.Spec.PostEphemeralV1SendBodyDto SetCardObject(this Im.Spec.PostEphemeralV1SendBodyDto Dto,
        Im.Dtos.MessageCard CardObject)
    {
        Dto.MsgType = CardObject.MessageType;
        Dto.Card = CardObject;

        return Dto;
    }

    /// <summary>
    /// 由于发送单人与批量的消息结构不一致，需要针对单人的消息进行特殊处理。目前已确认：富文本消息。
    /// <para>发现一个，处理一个。</para>
    /// </summary>
    /// <param name="CardOrContent">消息对象，包括以下：
    /// <list type="bullet">
    /// <item>TextContent</item>
    /// <item>PostContent</item>
    /// <item>ImageContent</item>
    /// <item>FileContent</item>
    /// <item>AudioContent</item>
    /// <item>MediaContent</item>
    /// <item>StickerContent</item>
    /// <item>ShareChatContent</item>
    /// <item>ShareUserContent</item>
    /// <item>SystemDividerContent</item>
    /// <item>ElementsCardDto</item>
    /// <item>TemplateCardDto</item>
    /// <item>EntityCardDto</item>
    /// </list>
    /// </param>
    private static string SerializeSingleReceiverContent(Im.Dtos.IHasMessageType CardOrContent)
    {
        return CardOrContent switch
        {
            Im.Dtos.PostContent post => JsonSerializer.Serialize(post.Post, options),
            _ => JsonSerializer.Serialize(CardOrContent, CardOrContent.GetType(), options)
        };
    }

    /// <summary>
    /// 设置消息类型及内容
    /// </summary>
    /// <param name="Dto">发送消息 请求体</param>
    /// <param name="CardOrContent">消息对象，包括以下：
    /// <list type="bullet">
    /// <item>TextContent</item>
    /// <item>PostContent</item>
    /// <item>ImageContent</item>
    /// <item>FileContent</item>
    /// <item>AudioContent</item>
    /// <item>MediaContent</item>
    /// <item>StickerContent</item>
    /// <item>ShareChatContent</item>
    /// <item>ShareUserContent</item>
    /// <item>SystemDividerContent</item>
    /// <item>ElementsCardDto</item>
    /// <item>TemplateCardDto</item>
    /// <item>EntityCardDto</item>
    /// </list>
    /// </param>
    public static Im.PostImV1MessagesBodyDto SetContent(this Im.PostImV1MessagesBodyDto Dto,
        Im.Dtos.IHasMessageType CardOrContent)
    {
        Dto.MsgType = CardOrContent.MessageType;
        Dto.Content = SerializeSingleReceiverContent(CardOrContent);

        return Dto;
    }

    /// <summary>
    /// 设置消息类型及内容
    /// </summary>
    /// <param name="Dto">回复消息 请求体</param>
    /// <param name="CardOrContent">消息对象，包括以下：
    /// <list type="bullet">
    /// <item>TextContent</item>
    /// <item>PostContent</item>
    /// <item>ImageContent</item>
    /// <item>FileContent</item>
    /// <item>AudioContent</item>
    /// <item>MediaContent</item>
    /// <item>StickerContent</item>
    /// <item>ShareChatContent</item>
    /// <item>ShareUserContent</item>
    /// <item>SystemDividerContent</item>
    /// <item>ElementsCardDto</item>
    /// <item>TemplateCardDto</item>
    /// <item>EntityCardDto</item>
    /// </list>
    /// </param>
    public static Im.PostImV1MessagesByMessageIdReplyBodyDto SetContent(this Im.PostImV1MessagesByMessageIdReplyBodyDto Dto,
        Im.Dtos.IHasMessageType CardOrContent)
    {
        Dto.MsgType = CardOrContent.MessageType;
        Dto.Content = SerializeSingleReceiverContent(CardOrContent);

        return Dto;
    }

    /// <summary>
    /// 设置消息类型及内容
    /// </summary>
    /// <param name="Dto">编辑消息 请求体</param>
    /// <param name="CardOrContent">消息对象，包括以下：
    /// <list type="bullet">
    /// <item>TextContent</item>
    /// <item>PostContent</item>
    /// <item>ImageContent</item>
    /// <item>FileContent</item>
    /// <item>AudioContent</item>
    /// <item>MediaContent</item>
    /// <item>StickerContent</item>
    /// <item>ShareChatContent</item>
    /// <item>ShareUserContent</item>
    /// <item>SystemDividerContent</item>
    /// <item>ElementsCardDto</item>
    /// <item>TemplateCardDto</item>
    /// <item>EntityCardDto</item>
    /// </list>
    /// </param>
    public static Im.PutImV1MessagesByMessageIdBodyDto SetContent(this Im.PutImV1MessagesByMessageIdBodyDto Dto,
        Im.Dtos.IHasMessageType CardOrContent)
    {
        Dto.MsgType = CardOrContent.MessageType;
        Dto.Content = SerializeSingleReceiverContent(CardOrContent);

        return Dto;
    }

    /// <summary>
    /// 设置消息类型及内容
    /// </summary>
    /// <param name="Dto">批量发送消息 请求体</param>
    /// <param name="CardOrContent">消息对象，包括以下：
    /// <list type="bullet">
    /// <item>TextContent</item>
    /// <item>PostContent</item>
    /// <item>ImageContent</item>
    /// <item>FileContent</item>
    /// <item>AudioContent</item>
    /// <item>MediaContent</item>
    /// <item>StickerContent</item>
    /// <item>ShareChatContent</item>
    /// <item>ShareUserContent</item>
    /// <item>SystemDividerContent</item>
    /// <item>ElementsCardDto</item>
    /// <item>TemplateCardDto</item>
    /// <item>EntityCardDto</item>
    /// </list>
    /// </param>
    public static Im.Spec.PostMessageV4BatchSendBodyDto SetCardOrContent(this Im.Spec.PostMessageV4BatchSendBodyDto Dto,
        Im.Dtos.IHasMessageType CardOrContent)
    {
        Dto.MsgType = CardOrContent.MessageType;
        if (CardOrContent is Im.Dtos.MessageCard)
        {
            Dto.Card = CardOrContent;
        }
        else if (CardOrContent is Im.Dtos.MessageContent)
        {
            Dto.Content = CardOrContent;
        }
        else throw new Exceptions.MessageTypeNotSupportedException($"{CardOrContent.GetType()}不受支持！");

        return Dto;
    }

    /// <summary>
    /// 添加富文本元素节点
    /// </summary>
    /// <param name="Dto">富文本消息</param>
    /// <param name="Elements">元素节点
    /// 支持的元素清单如下：位于 Im.Dtos 空间下
    /// <list type="bullet">
    /// <item>TextElement</item>
    /// <item>LinkElement</item>
    /// <item>AtElement</item>
    /// <item>ImgElement</item>
    /// <item>MediaElement</item>
    /// <item>EmotionElement</item>
    /// <item>HrElement</item>
    /// <item>MdElement</item>
    /// <item>CodeBlockElement</item>
    /// </list>
    /// </param>
    /// <returns>富文本消息</returns>
    public static Im.Dtos.PostContent.PostLanguage AddContent(this Im.Dtos.PostContent.PostLanguage Dto, Im.Dtos.Element[] Elements)
    {
        Dto.Content = [.. Dto.Content, Elements];

        return Dto;
    }

    /// <summary>
    /// 添加组件
    /// </summary>
    /// <param name="Dto">表单容器组件</param>
    /// <param name="Element">表单组件，支持的组件类型如下：
    /// <list type="bullet">
    /// <item>MarkdownElement：支持 markdown 语法的组件</item>
    /// <item>ColumnSetElement：分栏组件</item>
    /// <item>ColumnElement：分栏-列组件</item>
    /// <item>InputFormElement：输入框组件</item>
    /// <item>ButtonFormElement：按钮组件</item>
    /// </list>
    /// </param>
    /// <returns></returns>
    public static Im.Dtos.FormContainerElement AddElement(this Im.Dtos.FormContainerElement Dto, Im.Dtos.Element Element)
    {
        Dto.Elements = [.. Dto.Elements, Element];

        return Dto;
    }

    /// <summary>
    /// 设置文本内容
    /// </summary>
    /// <param name="Dto">普通文本组件</param>
    /// <param name="Element">普通文本内容，支持组件为：
    /// <list type="bullet">
    /// <item>PlainTextElement</item>
    /// <item>LarkMdElement</item>
    /// </list>
    /// </param>
    /// <returns></returns>
    public static Im.Dtos.DivElement SetText(this Im.Dtos.DivElement Dto, Im.Dtos.IAmDivTextElement Element)
    {
        Dto.Text = Element;

        return Dto;
    }

    /// <summary>
    /// 设置文本图标
    /// </summary>
    /// <param name="Dto">普通文本组件</param>
    /// <param name="Element">普通文本图标，支持组件为：
    /// <list type="bullet">
    /// <item>StandardIconElement</item>
    /// <item>CustomIconElement</item>
    /// </list>
    /// </param>
    /// <returns></returns>
    public static Im.Dtos.DivElement SetIcon(this Im.Dtos.DivElement Dto, Im.Dtos.IconElement Element)
    {
        Dto.Icon = Element;

        return Dto;
    }

    /// <summary>
    /// 设置文本图标
    /// </summary>
    /// <param name="Dto">人员列表组件</param>
    /// <param name="Element">普通文本图标，支持组件为：
    /// <list type="bullet">
    /// <item>StandardIconElement</item>
    /// <item>CustomIconElement</item>
    /// </list>
    /// </param>
    /// <returns></returns>
    public static Im.Dtos.PersonListElement SetIcon(this Im.Dtos.PersonListElement Dto, Im.Dtos.IconElement Element)
    {
        Dto.Icon = Element;

        return Dto;
    }

    /// <summary>
    /// 设置文本图标
    /// </summary>
    /// <param name="Dto">按钮组件</param>
    /// <param name="Element">普通文本图标，支持组件为：
    /// <list type="bullet">
    /// <item>StandardIconElement</item>
    /// <item>CustomIconElement</item>
    /// </list>
    /// </param>
    /// <returns></returns>
    public static Im.Dtos.FormButtonElement SetIcon(this Im.Dtos.FormButtonElement Dto, Im.Dtos.IconElement Element)
    {
        Dto.Icon = Element;

        return Dto;
    }

    /// <summary>
    /// 添加子元素组件
    /// </summary>
    /// <param name="Dto">备注组件</param>
    /// <param name="Element">表单组件，支持的组件类型如下：
    /// <list type="bullet">
    /// <item>StandardIconElement：图标组件</item>
    /// <item>CustomIconElement：图标组件</item>
    /// <item>ImgElement：图片组件</item>
    /// <item>PlainTextElement：普通文本组件</item>
    /// <item>LarkMdElement：普通文本（Markdown）组件</item>
    /// </list>
    /// </param>
    /// <returns></returns>
    public static Im.Dtos.NoteElement AddElement(this Im.Dtos.NoteElement Dto, Im.Dtos.IAmNoteElement Element)
    {
        Dto.Elements = [.. Dto.Elements, Element];

        return Dto;
    }

    /// <summary>
    /// 添加列对象
    /// </summary>
    /// <param name="Dto">表格组件</param>
    /// <param name="Column">列对象</param>
    /// <returns></returns>
    public static Im.Dtos.TableElement AddColumn(this Im.Dtos.TableElement Dto, Im.Dtos.TableElement.Column Column)
    {
        Dto.Columns = [.. Dto.Columns, Column];

        return Dto;
    }

    /// <summary>
    /// 添加行对象
    /// <para>请注意：建议在所有 ⌈列对象⌋ 添加完成之后再使用本方法进行添加行对象。</para>
    /// <para>本方法的重要特性是会自动根据 ⌈列对象⌋ 过滤未定义的 ⌈列数据⌋，避免接口报错。同时还可以复用数据源，简化使用难度。</para>
    /// </summary>
    /// <param name="Dto">表格组件</param>
    /// <param name="Rows">行对象</param>
    /// <returns></returns>
    public static Im.Dtos.TableElement SetRows(this Im.Dtos.TableElement Dto, IEnumerable<object> Rows)
    {
        var data = JsonSerializer.Deserialize<Dictionary<string, object>[]>(JsonSerializer.Serialize(Rows)) ?? [];

        if (Dto.Columns.Length > 0)
        {
            var columns = Dto.Columns.Select(p => p.Name);
            data = [.. data.Select(p => p.Where(k => columns.Contains(k.Key)).ToDictionary(k => k.Key, v => v.Value))];
        }

        Dto.Rows = data;

        return Dto;
    }

    /// <summary>
    /// 添加卡片信息
    /// </summary>
    /// <param name="Dto">卡片交互响应体</param>
    /// <param name="Card">卡片内容</param>
    /// <returns></returns>
    public static CallbackEvents.CardActionTriggerResponseDto SetCard(this CallbackEvents.CardActionTriggerResponseDto Dto, Im.Dtos.MessageCard Card)
    {
        Dto.Card ??= new();
        switch (Card)
        {
            case Im.Dtos.TemplateCardDto templateCardDto:
                Dto.Card.Data = templateCardDto.Data;
                Dto.Card.Type = templateCardDto.Type;
                break;
            default:
                Dto.Card.Data = Card;
                Dto.Card.Type = "raw";
                break;
        }
        return Dto;
    }

    /// <summary>
    /// 多维表格的查询记录结果转为字符串值
    /// </summary>
    /// <param name="record">查询记录 响应体中的 AppTableRecord 对象</param>
    /// <param name="tableFields">多维表字段信息数组</param>
    /// <param name="serializer">序列化规则</param>
    /// <returns></returns>
    public static Dictionary<string, string?> SerializeFieldsToStringValue(this Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchResponseDto.AppTableRecord record,
        IEnumerable<Base.GetBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto.AppTableFieldForList>? tableFields,
        Base.Dtos.IBitableRecordSerializer serializer)
    {
        // 遍历 record 中的每个字段，将其转换为键值对，键为字段名，值为转换后的字符串值
        return record.Fields
            .Select(p => new
            {
                p.Key,
                // 调用 GetFieldValueAsString 方法获取字段的字符串值
                Value = GetFieldValueAsString(p.Value, tableFields?.FirstOrDefault(k => k.FieldName == p.Key), serializer)
            })
            .ToDictionary(p => p.Key, p => p.Value);
    }

    // 该方法用于获取字段的字符串值
    private static string? GetFieldValueAsString(object? value, Base.GetBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto.AppTableFieldForList? field, Base.Dtos.IBitableRecordSerializer serializer)
    {
        return value is null
            ? null
            : ConvertFieldValueToStringByType(field?.Type, field?.UiType, value, serializer);
    }

    // 该方法根据字段类型将字段值转换为字符串
    private static string? ConvertFieldValueToStringByType(int? type, string? uiType, object value, Base.Dtos.IBitableRecordSerializer serializer)
    {
        try
        {
            string json = JsonSerializer.Serialize(value);
            using var jd = JsonDocument.Parse(json);
            string key = GetKey(uiType, type, jd.RootElement);

            if (!serializer.TypePairs.TryGetValue(key, out var _type)) return null;
            json = AdjustJsonIfArray(_type, jd.RootElement, json);

            var record = JsonSerializer.Deserialize(json, _type);
            if (record is null) return null;

            return GetSerializedValue(uiType, type, jd.RootElement.ValueKind, record, serializer);
        }
        catch (Exception ex)
        {
            // 可以根据实际情况进行日志记录等操作
            Console.WriteLine($"Error in ConvertFieldValueToStringByType: {ex.Message}");
            return null;
        }
    }

    private static string? GetSerializedValue(string? uiType, int? type, JsonValueKind valueKind, object record, Base.Dtos.IBitableRecordSerializer serializer)
    {
        if (uiType is not null)
        {
            return HandleUiType(uiType, record, serializer);
        }
        else if (type is not null)
        {
            return HandleType(type.Value, record, serializer);
        }
        else
        {
            return HandleJsonValueKind(valueKind, record, serializer);
        }
    }

    private static string GetKey(string? uiType, int? type, JsonElement je)
    {
        return uiType is not null
            ? uiType
            : type is not null
                ? $"Type{type}"
                : $"JsonValueKind{je.ValueKind}";
    }

    private static string AdjustJsonIfArray(Type _type, JsonElement je, string json)
    {
        return _type.IsArray && je.ValueKind != JsonValueKind.Array
            ? ConvertToJsonArray(je).GetRawText()
            : json;
    }

    private static JsonElement ConvertToJsonArray(JsonElement element)
    {
        using var memoryStream = new MemoryStream();
        using var jsonWriter = new Utf8JsonWriter(memoryStream);

        jsonWriter.WriteStartArray();
        WriteJsonElementToWriter(jsonWriter, element);
        jsonWriter.WriteEndArray();
        jsonWriter.Flush();

        var jsonBytes = memoryStream.ToArray();
        return JsonDocument.Parse(jsonBytes).RootElement;
    }

    private static void WriteJsonElementToWriter(Utf8JsonWriter writer, JsonElement element)
    {
        try
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    writer.WriteRawValue(element.GetRawText());
                    break;
                case JsonValueKind.String:
                    writer.WriteStringValue(element.GetString());
                    break;
                case JsonValueKind.Number:
                    writer.WriteNumberValue(element.GetDouble());
                    break;
                case JsonValueKind.True:
                case JsonValueKind.False:
                    writer.WriteBooleanValue(element.GetBoolean());
                    break;
                case JsonValueKind.Null:
                    writer.WriteNullValue();
                    break;
                default:
                    // 其他情况，可根据需求扩展处理逻辑
                    break;
            }
        }
        catch (Exception ex)
        {
            // 可以根据实际情况记录日志或进行其他处理
            Console.WriteLine($"Error writing JSON element: {ex.Message}");
        }
    }

    private static string? HandleUiType(string uiType, object record, Base.Dtos.IBitableRecordSerializer serializer)
    {
        return uiType switch
        {
            "Text" => serializer.TextRecordToString(record as Base.Dtos.TextRecord[]),
            "Email" => serializer.TextRecordToString(record as Base.Dtos.TextRecord[]),
            "Barcode" => serializer.BarcodeRecordToString(record as Base.Dtos.TextRecord[]),
            "Number" => serializer.NumberRecordToString(record as decimal[]),
            "Progress" => serializer.ProgressRecordToString(record as decimal[]),
            "Currency" => serializer.CurrencyRecordToString(record as decimal[]),
            "Rating" => serializer.RatingRecordToString(record as decimal[]),
            "SingleSelect" => serializer.SingleSelectRecordToString(record as string[]),
            "MultiSelect" => serializer.MultiSelectRecordToString(record as string[]),
            "DateTime" => serializer.DateTimeRecordToString(record as ulong[]),
            "Checkbox" => serializer.CheckboxRecordToString(record as bool[]),
            "User" => serializer.UserRecordToString(record as Base.Dtos.UserRecord[]),
            "GroupChat" => serializer.GroupChatRecordToString(record as Base.Dtos.GroupChatRecord[]),
            "Stage" => serializer.StageRecordToString(record),
            "Phone" => serializer.PhoneRecordToString(record as string[]),
            "Url" => serializer.UrlRecordToString(record as Base.Dtos.UrlRecord[]),
            "Attachment" => serializer.AttachmentRecordToString(record as Base.Dtos.AttachmentRecord[]),
            "SingleLink" => serializer.SingleLinkRecordToString(record as Base.Dtos.LinkRecord),
            "Formula" or "Lookup" when record is Base.Dtos.FormulaRecord f
            => ConvertFieldValueToStringByType(f.Type, null, f.Value, serializer),
            "DuplexLink" => serializer.DuplexLinkRecordToString(record as Base.Dtos.LinkRecord),
            "Location" => serializer.LocationRecordToString(record as Base.Dtos.LocationRecord[]),
            "CreatedTime" => serializer.CreatedTimeRecordToString(record as ulong[]),
            "ModifiedTime" => serializer.ModifiedTimeRecordToString(record as ulong[]),
            "CreatedUser" => serializer.UserRecordToString(record as Base.Dtos.UserRecord[]),
            "ModifiedUser" => serializer.UserRecordToString(record as Base.Dtos.UserRecord[]),
            "AutoNumber" => serializer.AutoNumberRecordToString(record as string[]),
            "Button" => serializer.ButtonRecordToString(record),
            _ => null
        };
    }

    private static string? HandleType(int type, object record, Base.Dtos.IBitableRecordSerializer serializer)
    {
        return type switch
        {
            1 => serializer.TextRecordToString(record as Base.Dtos.TextRecord[]),
            2 => serializer.NumberRecordToString(record as decimal[]),
            3 => serializer.SingleSelectRecordToString(record as string[]),
            4 => serializer.MultiSelectRecordToString(record as string[]),
            5 => serializer.DateTimeRecordToString(record as ulong[]),
            7 => serializer.CheckboxRecordToString(record as bool[]),
            11 => serializer.UserRecordToString(record as Base.Dtos.UserRecord[]),
            13 => serializer.PhoneRecordToString(record as string[]),
            15 => serializer.UrlRecordToString(record as Base.Dtos.UrlRecord[]),
            17 => serializer.AttachmentRecordToString(record as Base.Dtos.AttachmentRecord[]),
            19 or 20 when record is Base.Dtos.FormulaRecord f
            => ConvertFieldValueToStringByType(f.Type, null, f.Value, serializer),
            22 => serializer.LocationRecordToString(record as Base.Dtos.LocationRecord[]),
            23 => serializer.GroupChatRecordToString(record as Base.Dtos.GroupChatRecord[]),
            1001 => serializer.CreatedTimeRecordToString(record as ulong[]),
            1002 => serializer.ModifiedTimeRecordToString(record as ulong[]),
            1003 => serializer.CreatedUserRecordToString(record as Base.Dtos.UserRecord[]),
            1004 => serializer.ModifiedUserRecordToString(record as Base.Dtos.UserRecord[]),
            1005 => serializer.AutoNumberRecordToString(record as string[]),
            _ => null
        };
    }

    private static string? HandleJsonValueKind(JsonValueKind valueKind, object record, Base.Dtos.IBitableRecordSerializer serializer)
    {
        return valueKind switch
        {
            JsonValueKind.False or JsonValueKind.True => serializer.CheckboxRecordToString(record as bool[]),
            JsonValueKind.Number => serializer.NumberRecordToString(record as decimal[]),
            JsonValueKind.String => serializer.TextRecordToString(record as Base.Dtos.TextRecord[]),
            JsonValueKind.Object when record is Base.Dtos.FormulaRecord f
            => ConvertFieldValueToStringByType(f.Type, null, f.Value, serializer),
            JsonValueKind.Array => serializer.TextRecordToString(record as Base.Dtos.TextRecord[]),
            _ => null
        };
    }
}