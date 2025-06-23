namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取内推信息 响应体
/// <para>接口ID：6964264269274595330</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/referral/get_by_application</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral%2fget_by_application</para>
/// </summary>
[TestClass]
public class Test_GetHireV1ReferralsGetByApplicationResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "referral": {
            "id": "7392247983414413606",
            "application_id": "643452344576878",
            "create_time": 1618899376474,
            "referral_user_id": "ou_669760b021dbd9edbf2f3dc11b3a25ed",
            "referral_user": {
                "id": "ou_669760b021dbd9edbf2f3dc11b3a25ed",
                "name": {
                    "zh_cn": "张三",
                    "en_us": "zhangsan"
                }
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1ReferralsGetByApplicationResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}