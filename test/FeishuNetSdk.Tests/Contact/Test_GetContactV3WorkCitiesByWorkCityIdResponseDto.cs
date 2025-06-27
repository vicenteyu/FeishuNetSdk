// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetContactV3WorkCitiesByWorkCityIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取单个工作城市信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 获取单个工作城市信息 响应体
/// <para>接口ID：7256700963175022596</para>
/// <para>文档地址：https://open.feishu.cn/document/contact-v3/work_city/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fwork_city%2fget</para>
/// </summary>
[TestClass]
public class Test_GetContactV3WorkCitiesByWorkCityIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "work_city": {
            "work_city_id": "0dd1ec95f021",
            "name": "北京",
            "i18n_name": [
                {
                    "locale": "zh_cn",
                    "value": "北京"
                }
            ],
            "status": true
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3WorkCitiesByWorkCityIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}