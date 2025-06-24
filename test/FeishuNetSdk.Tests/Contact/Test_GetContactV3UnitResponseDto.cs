// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetContactV3UnitResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取单位列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 获取单位列表 响应体
/// <para>接口ID：7023995901275308035</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2flist</para>
/// </summary>
[TestClass]
public class Test_GetContactV3UnitResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "unitlist": [
            {
                "unit_id": "BU121",
                "name": "消费者事业部",
                "unit_type": "事业部"
            }
        ],
        "has_more": true,
        "page_token": "AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBudfdagatagdd="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3UnitResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}