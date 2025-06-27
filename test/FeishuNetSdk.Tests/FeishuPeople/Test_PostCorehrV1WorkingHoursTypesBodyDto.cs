// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1WorkingHoursTypesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建工时制度 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建工时制度 请求体
/// <para>接口ID：7072647640912117762</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/working_hours_type/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fworking_hours_type%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1WorkingHoursTypesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": "1",
    "name": [
        {
            "lang": "zh-CN",
            "value": "张三"
        }
    ],
    "country_region_id_list": [
        "6890452208593356295"
    ],
    "default_for_job": true,
    "active": true,
    "custom_fields": [
        {
            "field_name": "name",
            "value": "\"Sandy\""
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1WorkingHoursTypesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}