// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchContactV3UsersByUserIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改用户部分信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 修改用户部分信息 请求体
/// <para>接口ID：6943913881476792347</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchContactV3UsersByUserIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "张三",
    "en_name": "San Zhang",
    "nickname": "Alex Zhang",
    "email": "zhangsan@gmail.com",
    "mobile": "13011111111",
    "mobile_visible": false,
    "gender": 1,
    "avatar_key": "2500c7a9-5fff-4d9a-a2de-3d59614ae28g",
    "department_ids": [
        "od-4e6ac4d14bcd5071a37a39de902c7141"
    ],
    "leader_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
    "city": "杭州",
    "country": "CN",
    "work_station": "北楼-H34",
    "join_time": 2147483647,
    "employee_no": "1",
    "employee_type": 1,
    "orders": [
        {
            "department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
            "user_order": 100,
            "department_order": 100,
            "is_primary_dept": true
        }
    ],
    "custom_attrs": [
        {
            "type": "TEXT",
            "id": "DemoId",
            "value": {
                "text": "DemoText",
                "url": "http://www.fs.cn",
                "pc_url": "http://www.fs.cn",
                "option_id": "edcvfrtg",
                "generic_user": {
                    "id": "9b2fabg5",
                    "type": 1
                }
            }
        }
    ],
    "enterprise_email": "demo@mail.com",
    "job_title": "xxxxx",
    "is_frozen": false,
    "job_level_id": "mga5oa8ayjlp9rb",
    "job_family_id": "mga5oa8ayjlpzjq",
    "subscription_ids": [
        "23213213213123123"
    ],
    "dotted_line_leader_user_ids": [
        "ou_7dab8a3d3cdcc9da365777c7ad535d62"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PatchContactV3UsersByUserIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}