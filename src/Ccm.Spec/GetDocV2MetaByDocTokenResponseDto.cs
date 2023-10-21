using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取旧版文档元信息 响应体
/// <para>此接口只支持查询旧版文档元信息，如果需要查询新版文档元信息，请使用[获取元数据](https://open.feishu.cn/document/ukTMukTMukTM/uMjN3UjLzYzN14yM2cTN)接口。</para>
/// <para>接口ID：6907569524100448257</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/document/obtain-document-meta</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuczN3UjL3czN14yN3cTN</para>
/// </summary>
public record GetDocV2MetaByDocTokenResponseDto
{
    /// <summary>
    /// <para>创建日期</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("create_date")]
    public string? CreateDate { get; set; }

    /// <summary>
    /// <para>创建时间戳</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("create_time")]
    public int? CreateTime { get; set; }

    /// <summary>
    /// <para>创建者open_id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("creator")]
    public string? Creator { get; set; }

    /// <summary>
    /// <para>创建者用户名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("create_user_name")]
    public string? CreateUserName { get; set; }

    /// <summary>
    /// <para>删除标志，0表示正常访问未删除，1表示在回收站，2表示已经彻底删除</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("delete_flag")]
    public int? DeleteFlag { get; set; }

    /// <summary>
    /// <para>最后编辑时间戳</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("edit_time")]
    public int? EditTime { get; set; }

    /// <summary>
    /// <para>最后编辑者用户名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("edit_user_name")]
    public string? EditUserName { get; set; }

    /// <summary>
    /// <para>是否外部文档</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("is_external")]
    public bool? IsExternal { get; set; }

    /// <summary>
    /// <para>是否在接口调用者目录里快速访问</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("is_pined")]
    public bool? IsPined { get; set; }

    /// <summary>
    /// <para>是否在接口调用者目录里收藏</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("is_stared")]
    public bool? IsStared { get; set; }

    /// <summary>
    /// <para>文档类型，固定是doc</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("obj_type")]
    public string? ObjType { get; set; }

    /// <summary>
    /// <para>当前所有者open_id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("owner")]
    public string? Owner { get; set; }

    /// <summary>
    /// <para>当前所有者用户名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("owner_user_name")]
    public string? OwnerUserName { get; set; }

    /// <summary>
    /// <para>处理请求时的服务器时间戳</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("server_time")]
    public int? ServerTime { get; set; }

    /// <summary>
    /// <para>文档所在租户id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("tenant_id")]
    public string? TenantId { get; set; }

    /// <summary>
    /// <para>文档名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>文档类型，固定是2</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("type")]
    public int? Type { get; set; }

    /// <summary>
    /// <para>文档url</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("url")]
    public string? Url { get; set; }
}
