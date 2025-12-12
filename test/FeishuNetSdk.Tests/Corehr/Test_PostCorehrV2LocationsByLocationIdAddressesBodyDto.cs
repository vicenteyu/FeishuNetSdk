// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2LocationsByLocationIdAddressesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加地点地址 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 添加地点地址 请求体
/// <para>接口ID：7420421437192912899</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/location-address/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation-address%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2LocationsByLocationIdAddressesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "country_region_id": "6862995757234914824",
    "region_id": "6863326264296474119",
    "city_id": "6863333555859097096",
    "distinct_id": "6863333556291110408",
    "address_line1": "丹佛测试地址-纽埃时区",
    "address_line2": "PoewH",
    "address_line3": "PoewH",
    "address_line4": "jmwJc",
    "address_line5": "jmwJc",
    "address_line6": "jmwJc",
    "address_line7": "jmwJc",
    "address_line8": "rafSu",
    "address_line9": "McPRG",
    "local_address_line1": "丹佛测试地址-纽埃时区",
    "local_address_line2": "丹佛测试地址-纽埃时区",
    "local_address_line3": "丹佛测试地址-纽埃时区",
    "local_address_line4": "丹佛测试地址-纽埃时区",
    "local_address_line5": "丹佛测试地址-纽埃时区",
    "local_address_line6": "丹佛测试地址-纽埃时区",
    "local_address_line7": "丹佛测试地址-纽埃时区",
    "local_address_line8": "丹佛测试地址-纽埃时区",
    "local_address_line9": "丹佛测试地址-纽埃时区",
    "postal_code": "611530",
    "address_types": [
        {
            "enum_name": "phone_type"
        }
    ],
    "is_primary": true,
    "is_public": true
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2LocationsByLocationIdAddressesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}