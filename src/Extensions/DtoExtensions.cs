// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DtoExtensions.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
namespace FeishuNetSdk
{
    /// <summary>
    /// DTO扩展方法
    /// </summary>
    public static class DtoExtensions
    {
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
        public static Approval.Dtos.FromControl[]? GetFormControls(this Approval.GetApprovalV4ApprovalsByApprovalCodeResponseDto? Dto)
                => Dto is null ? null
                    : System.Text.Json.JsonSerializer.Deserialize<Approval.Dtos.FromControl[]>(Dto.Form);

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
        /// <item>ElementsCardDto</item>
        /// <item>TemplateCardDto</item>
        /// </list>
        /// </param>
        public static Im.PostImV1MessagesBodyDto SetContent(
            this Im.PostImV1MessagesBodyDto Dto,
            Im.Dtos.IHasMessageType CardOrContent)
        {
            Dto.MsgType = CardOrContent.MessageType;
            Dto.Content = System.Text.Json.JsonSerializer.Serialize(CardOrContent, CardOrContent.GetType());

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
            else throw new Exceptions.MessageTypeNotSupportedException($"{nameof(CardOrContent)}不受支持！");

            return Dto;
        }

        /// <summary>
        /// 添加元素节点
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
    }
}
