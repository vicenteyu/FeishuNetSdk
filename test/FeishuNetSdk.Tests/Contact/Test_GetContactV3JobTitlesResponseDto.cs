// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetContactV3JobTitlesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取租户职务列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 获取租户职务列表 响应体
/// <para>接口ID：7256700963175006212</para>
/// <para>文档地址：https://open.feishu.cn/document/contact-v3/job_title/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_title%2flist</para>
/// </summary>
[TestClass]
public class Test_GetContactV3JobTitlesResponseDto : TestBase
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
                "job_title_id": "b5565c46b749",
                "name": "高级工程师",
                "i18n_name": [
                    {
                        "locale": "zh_cn",
                        "value": "专家"
                    }
                ],
                "status": true
            }
        ],
        "page_token": "1r5QdASJi1sp5aJn",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3JobTitlesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}