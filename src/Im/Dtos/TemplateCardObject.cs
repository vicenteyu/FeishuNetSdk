namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 卡片模板
    /// </summary>
    public record TemplateCardObject : TemplateCard, IHasOpenIds
    {
        /// <summary>
        /// <para>指定需要更新的用户，共享卡片默认更新所有人卡片，无需填写该字段。推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_ids")]
        public string[]? OpenIds { get; set; }
    }
}
