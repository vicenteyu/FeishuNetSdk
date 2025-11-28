// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="GetCorehrV2SignatureNodesListByFileIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取文件签署节点信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取文件签署节点信息 响应体
/// <para>该接口可以通过电子签文件ID查询到该电子签文件的签署流程的各个节点信息，包括签署节点、盖章节点、审阅节点等，各个节点有对应的内容、完成时间、审阅人、盖章人等信息</para>
/// <para>接口ID：7398535900936863747</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/list_by_file_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_node%2flist_by_file_id</para>
/// </summary>
public record GetCorehrV2SignatureNodesListByFileIdResponseDto
{
    /// <summary>
    /// <para>电子签文件签署流程各个节点列表信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("signature_nodes")]
    public SignatureNode[]? SignatureNodes { get; set; }

    /// <summary>
    /// <para>电子签文件签署流程各个节点列表信息</para>
    /// </summary>
    public record SignatureNode
    {
        /// <summary>
        /// <para>节点相关的角色信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("user_infos")]
        public SignatureUserInfo[]? UserInfos { get; set; }

        /// <summary>
        /// <para>节点相关的角色信息</para>
        /// </summary>
        public record SignatureUserInfo
        {
            /// <summary>
            /// <para>员工雇佣ID，可以通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取员工详细信息</para>
            /// <para>必填：是</para>
            /// <para>示例值：7300476612163913260</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>节点状态，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签文件状态（signature_file_state）枚举定义部分获得</para>
        /// <para>必填：是</para>
        /// <para>示例值：Initiated</para>
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// <para>节点完成时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-12-31 12:21:10</para>
        /// </summary>
        [JsonPropertyName("finish_time")]
        public string? FinishTime { get; set; }

        /// <summary>
        /// <para>节点最近更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-12-31 12:21:10</para>
        /// </summary>
        [JsonPropertyName("updated_time")]
        public string? UpdatedTime { get; set; }

        /// <summary>
        /// <para>当前节点是否为正在处理的节点</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_ongoing")]
        public bool IsOngoing { get; set; }

        /// <summary>
        /// <para>当前节点操作名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("role_label")]
        public SignatureEnumInfoLabel RoleLabel { get; set; } = new();

        /// <summary>
        /// <para>当前节点操作名称</para>
        /// </summary>
        public record SignatureEnumInfoLabel
        {
            /// <summary>
            /// <para>当前节点的操作名称中文展示，如：发起</para>
            /// <para>必填：否</para>
            /// <para>示例值：发起</para>
            /// </summary>
            [JsonPropertyName("zh")]
            public string? Zh { get; set; }

            /// <summary>
            /// <para>当前节点的操作名称英文展示，如：Initiate</para>
            /// <para>必填：否</para>
            /// <para>示例值：Initiate</para>
            /// </summary>
            [JsonPropertyName("en")]
            public string? En { get; set; }
        }

        /// <summary>
        /// <para>操作人类型，如：发起人、审阅人、签字人</para>
        /// <para>枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签文件流程节点签署角色（signature_node_sign_role）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：Initiator</para>
        /// </summary>
        [JsonPropertyName("sign_role")]
        public string? SignRole { get; set; }
    }
}
