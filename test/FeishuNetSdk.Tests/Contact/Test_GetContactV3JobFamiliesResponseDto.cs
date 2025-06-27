// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetContactV3JobFamiliesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取租户序列列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 获取租户序列列表 响应体
/// <para>接口ID：7194273514093395972</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/job_family/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_family%2flist</para>
/// </summary>
[TestClass]
public class Test_GetContactV3JobFamiliesResponseDto : TestBase
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
                "name": "产品",
                "description": "负责产品策略制定的相关工作",
                "parent_job_family_id": "mga5oa8ayjlpzjq",
                "status": true,
                "i18n_name": [
                    {
                        "locale": "zh_cn",
                        "value": "多语言内容"
                    }
                ],
                "i18n_description": [
                    {
                        "locale": "zh_cn",
                        "value": "多语言内容"
                    }
                ],
                "job_family_id": "mga5oa8ayjlpkzy"
            }
        ],
        "page_token": "AQD9/Rn9eij9Pm39ED40/RD/cIFmu77WxpxPB/2oHfQLZ+G8JG6tK7+ZnHiT7COhD2hMSICh/eBl7cpzU6JEC3J7COKNe4jrQ8ExwBCR",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3JobFamiliesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}