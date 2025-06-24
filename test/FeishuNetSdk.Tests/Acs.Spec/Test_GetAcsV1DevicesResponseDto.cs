// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetAcsV1DevicesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取门禁设备列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Acs.Spec;

/// <summary>
/// 测试 获取门禁设备列表 响应体
/// <para>接口ID：6979790924691980290</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/device/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fdevice%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAcsV1DevicesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "device_id": "6939433228970082593",
                "device_name": "东门",
                "device_sn": "3X811621174000240"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Acs.Spec.GetAcsV1DevicesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}