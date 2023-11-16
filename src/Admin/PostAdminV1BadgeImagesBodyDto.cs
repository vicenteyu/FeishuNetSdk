namespace FeishuNetSdk.Admin;
/// <summary>
/// 上传勋章图片 请求体
/// <para>通过该接口可以上传勋章详情图、挂饰图的文件，获取对应的文件key。</para>
/// <para>接口ID：7104154222309130243</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/badge/badge/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fbadge_image%2fcreate</para>
/// </summary>
public record PostAdminV1BadgeImagesBodyDto
{
    /// <summary>
    /// <para>图片的类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：勋章详情图</item>
    /// <item>2：勋章挂饰图</item>
    /// </list></para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("image_type")]
    public int ImageType { get; set; }
}
