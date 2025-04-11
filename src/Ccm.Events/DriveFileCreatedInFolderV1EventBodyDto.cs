// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="DriveFileCreatedInFolderV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文件夹下文件创建 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Events;
/// <summary>
/// 文件夹下文件创建 事件体
/// <para>当用户订阅的文件夹下有新建文件时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=drive&amp;version=v1&amp;resource=file&amp;event=created_in_folder)</para>
/// <para>接口ID：7443780882928549892</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/drive-v1/event/list/created_in_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fevents%2fcreated_in_folder</para>
/// </summary>
public record DriveFileCreatedInFolderV1EventBodyDto() : EventBodyDto("drive.file.created_in_folder_v1")
{
    /// <summary>
    /// <para>文件类型，与文件的 file_token 相匹配</para>
    /// <para>**示例值**：docx</para>
    /// <para>**可选值有**：</para>
    /// <para>doc:旧版文档,docx:新版文档,sheet:电子表格,bitable:多维表格,slides:幻灯片,file:文件</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `50` 字符</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc：旧版文档</item>
    /// <item>docx：新版文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>bitable：多维表格</item>
    /// <item>slides：幻灯片</item>
    /// <item>file：文件</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("file_type")]
    public string? FileType { get; set; }

    /// <summary>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>**示例值**：docxnBKgoMyY5OMbUG6FioTXuBe</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`22` ～ `27` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }

    /// <summary>
    /// <para>文件夹 Token。获取方式见[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`22` ～ `27` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("folder_token")]
    public string? FolderToken { get; set; }

    /// <summary>
    /// <para>操作者的用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>订阅者的用户 ID 列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `100`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("subscriber_ids")]
    public UserIdSuffix[]? SubscriberIds { get; set; }
}
