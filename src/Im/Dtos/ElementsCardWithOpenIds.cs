// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="ElementsCardWithOpenIds.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>卡片内容</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 卡片内容
    /// </summary>
    public record ElementsCardWithOpenIds : ElementsCardDto, IHasOpenIds
    {
        /// <summary>
        /// <para>指定需要更新的用户，共享卡片默认更新所有人卡片，无需填写该字段。推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_ids")]
        public string[]? OpenIds { get; set; }
    }
}
