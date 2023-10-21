using Newtonsoft.Json;
namespace FeishuNetSdk.Acs.Spec;
/// <summary>
/// 获取门禁设备列表 响应体
/// <para>使用该接口获取租户内所有门禁设备。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=acs&version=v1&resource=device&method=list)</para>
/// <para>接口ID：6979790924691980290</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/device/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fdevice%2flist</para>
/// </summary>
public record GetAcsV1DevicesResponseDto
{
    /// <summary>
    /// <para>-</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public Device[]? Items { get; set; }

    public record Device
    {
        /// <summary>
        /// <para>门禁设备 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("device_id")]
        public string? DeviceId { get; set; }

        /// <summary>
        /// <para>设备名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("device_name")]
        public string? DeviceName { get; set; }

        /// <summary>
        /// <para>设备 SN 码</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("device_sn")]
        public string? DeviceSn { get; set; }
    }
}
