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
#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace FeishuNetSdk
#pragma warning restore IDE0130 // 命名空间与文件夹结构不匹配
{
    /// <summary>
    /// DTO扩展方法
    /// </summary>
    public static class DtoExtensions
    {
        static readonly System.Text.Json.JsonSerializerOptions options = new()
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
            Dto.Form = System.Text.Json.JsonSerializer.Serialize(FormControls);

            return Dto;
        }

        /// <summary>
        /// 获取序列化的控件信息
        /// </summary>
        /// <param name="Dto">查看指定审批定义 响应体</param>
        /// <returns>序列化的控件数组</returns>
        public static Approval.Dtos.FormControlDto[]? GetFormControls(this Approval.GetApprovalV4ApprovalsByApprovalCodeResponseDto? Dto)
                => Dto is null ? null
                    : System.Text.Json.JsonSerializer.Deserialize<Approval.Dtos.FormControlDto[]>(Dto.Form);

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
        /// <param name="CardObject">消息卡片对象，包括以下：
        /// <list type="bullet">
        /// <item>ElementsCardDto</item>
        /// <item>TemplateCardDto</item>
        /// </list>
        /// </param>
        public static Im.PatchImV1MessagesByMessageIdBodyDto SetCardObject(this Im.PatchImV1MessagesByMessageIdBodyDto Dto,
            Im.Dtos.MessageCard CardObject)
        {
            Dto.Content = System.Text.Json.JsonSerializer.Serialize(CardObject, CardObject.GetType(), options);

            return Dto;
        }

        /// <summary>
        /// 设置消息类型及内容
        /// </summary>
        /// <param name="Dto">发送仅特定人可见的消息卡片 请求体</param>
        /// <param name="CardObject">消息卡片对象，包括以下：
        /// <list type="bullet">
        /// <item>ElementsCardDto</item>
        /// <item>TemplateCardDto</item>
        /// </list>
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
        /// </list>
        /// </param>
        private static string SerializeSingleReceiverContent(Im.Dtos.IHasMessageType CardOrContent)
        {
            return CardOrContent switch
            {
                Im.Dtos.PostContent post => System.Text.Json.JsonSerializer.Serialize(post.Post, options),
                _ => System.Text.Json.JsonSerializer.Serialize(CardOrContent, CardOrContent.GetType(), options)
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
            Dto.Content = Dto.Content.Append(Elements).ToArray();

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
            Dto.Elements = Dto.Elements.Append(Element).ToArray();

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
        public static Im.Dtos.DivElement SetIcon(this Im.Dtos.DivElement Dto, Im.Dtos.IAmDivIconElement Element)
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
        public static Im.Dtos.PersonListElement SetIcon(this Im.Dtos.PersonListElement Dto, Im.Dtos.IAmDivIconElement Element)
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
            Dto.Elements = Dto.Elements.Append(Element).ToArray();

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
            Dto.Columns = Dto.Columns.Append(Column).ToArray();

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
            var data = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, object>[]>(
                    System.Text.Json.JsonSerializer.Serialize(Rows))
                ?? Array.Empty<Dictionary<string, object>>();

            if (Dto.Columns.Length > 0)
            {
                var columns = Dto.Columns.Select(p => p.Name);
                data = data.Select(p => p.Where(k => columns.Contains(k.Key)).ToDictionary(k => k.Key, v => v.Value)).ToArray();
            }

            Dto.Rows = data;

            return Dto;
        }
    }
}
