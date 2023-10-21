using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增记录 请求体
/// <para>该接口用于在数据表中新增一条记录</para>
/// <para>接口ID：6952707657162522626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsBodyDto
{
    /// <summary>
    /// <para>数据表的字段，即数据表的列</para>
    /// <para>当前接口支持的字段类型请参考[接入指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#31f78a3c)</para>
    /// <para>不同类型字段的数据结构请参考[数据结构概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/development-guide/bitable-structure)</para>
    /// <para>必填：是</para>
    /// <para>示例值：{"多行文本":"HelloWorld"}</para>
    /// </summary>
    [JsonProperty("fields")]
    public object Fields { get; set; } = new();
}
