namespace FeishuNetSdk.Tests.Contact.Spec;

/// <summary>
/// 测试 批量新增用户 请求体
/// <para>接口ID：6907569743420997634</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//import-api/batch-add-users</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDOwUjLygDM14iM4ATN</para>
/// </summary>
[TestClass]
public class Test_PostContactV2UserBatchAddBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "users": [
        {
            "name": "张三",
            "departments": [
                "od-234355343342acdbef33"
            ],
            "user_id": "id_zhangsan",
            "email": "zhangsan@gmail.com",
            "mobile": "+8613822235671",
            "mobile_visible": false,
            "city": "北京",
            "country": "CN",
            "gender": 1,
            "employee_type": 1,
            "join_time": 1534222800,
            "leader_open_id": "ou_3454556545acdb12324",
            "leader_user_id": "2ab56f23",
            "employee_no": "323463",
            "custom_attrs": [
                {
                    "id": "C-6702376000044400907",
                    "value": {
                        "url": "http://www.feishu.cn/",
                        "pc_url": "http://www.feishu.cn/pc"
                    }
                }
            ],
            "work_station": "Poly, F6-123"
        },
        {
            "name": "李四",
            "departments": [
                "od-234355343342acdbef33"
            ],
            "user_id": "id_lisi",
            "mobile": "+8613822235672",
            "leader_user_id": "id_zhangsan"
        }
    ],
    "need_send_notification": false
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.Spec.PostContactV2UserBatchAddBodyDto>(json);
        Assert.IsNotNull(result);
    }
}