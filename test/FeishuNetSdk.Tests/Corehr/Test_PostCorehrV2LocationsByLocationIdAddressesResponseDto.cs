// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2LocationsByLocationIdAddressesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加地点地址 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 添加地点地址 响应体
/// <para>接口ID：7420421437192912899</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/location-address/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation-address%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2LocationsByLocationIdAddressesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "address_id": "6862995757234914824"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2LocationsByLocationIdAddressesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}