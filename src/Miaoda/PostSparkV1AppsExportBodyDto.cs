// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-10-17
//
// Last Modified By : yxr
// Last Modified On : 2026-10-17
// ************************************************************************
// <copyright file="PostSparkV1AppsExportBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>导出妙搭应用代码包 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 导出妙搭应用代码包 请求体
/// <para>导出妙搭应用的代码快照，以 zip 压缩包的二进制流形式直接返回，调用方可直接落盘为 `.zip` 文件。</para>
/// <para>按应用类型，导出内容有所不同：</para>
/// <para>| 应用类型 | 导出内容 |</para>
/// <para>| --- | --- |</para>
/// <para>| 全栈应用、前端应用等（代码托管在妙搭代码仓库） | 代码仓库中某次提交的快照。定位优先级：`release_id` &gt; `checkpoint_id` &gt; 默认分支最新提交。**不包含**沙箱中尚未保存为检查点的改动 |</para>
/// <para>| 静态 HTML 应用、豆包网页应用（仅托管构建产物） | 最近一次发布成功版本的构建产物（非原始源码），忽略 `checkpoint_id` 与 `release_id`。应用从未发布成功时无法导出 |</para>
/// <para>接口ID：7692846107466206181</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/export</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fexport</para>
/// </summary>
public record PostSparkV1AppsExportBodyDto
{
    /// <summary>
    /// <para>妙搭应用的唯一标识（`app_` 前缀），可在妙搭应用详情页获取，或调用[批量获取妙搭应用](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/list)接口获取。与 `meta_token` 必须且只能传一个，同时传入或均不传时返回 HTTP 400。</para>
    /// <para>必填：否</para>
    /// <para>示例值：app_4k6af8utt2s0n</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string? AppId { get; set; }

    /// <summary>
    /// <para>创意应用分享链接 `/page/&lt;token&gt;` 中的 token，适用于只持有分享链接、没有 `app_id` 的场景。与 `app_id` 必须且只能传一个，同时传入或均不传时返回 HTTP 400。服务端会反查对应的应用并按调用身份校验权限，持有 token 并不代表有权导出。</para>
    /// <para>必填：否</para>
    /// <para>示例值：Mhztd0abc123</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("meta_token")]
    public string? MetaToken { get; set; }

    /// <summary>
    /// <para>要导出的检查点 ID，可在妙搭应用详情页的对话历史列表中获取，取值需大于等于 0。不传或传 0 时导出默认分支的最后一次提交。与 `release_id` 不能同时传入，同时传入时返回 HTTP 400。仅托管构建产物的应用会忽略该参数。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7501234567890123456</para>
    /// </summary>
    [JsonPropertyName("checkpoint_id")]
    public string? CheckpointId { get; set; }

    /// <summary>
    /// <para>要导出的发布记录 ID，取值需大于 0，导出该次发布对应的代码提交，可从应用的发布记录中获取。与 `checkpoint_id` 不能同时传入，同时传入时返回 HTTP 400。仅托管构建产物的应用会忽略该参数。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7687553819701775556</para>
    /// </summary>
    [JsonPropertyName("release_id")]
    public string? ReleaseId { get; set; }
}
