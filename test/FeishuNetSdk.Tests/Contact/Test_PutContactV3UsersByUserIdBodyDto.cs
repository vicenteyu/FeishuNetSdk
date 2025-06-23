namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 更新用户所有信息 请求体
/// <para>接口ID：6943913881476808731</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//user/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutContactV3UsersByUserIdBodyDto : TestBase
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
    "mobile": "13011111111 (其他例子，中国大陆手机号: 13011111111 或 +8613011111111, 非中国大陆手机号:  +41446681800)",
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
    "is_frozen": false
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PutContactV3UsersByUserIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}