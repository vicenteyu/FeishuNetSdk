namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 添加笔试结果 响应体
/// <para>接口ID：7033979950131118084</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/exam/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexam%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExamsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "exam_id": "7031822096580868396",
        "application_id": "7031822096580868396",
        "exam_resource_name": "测试名字",
        "score": 95.5,
        "uuid": "6949805467799537964",
        "operator_id": "ou_xxx",
        "operate_time": "1637295516451"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ExamsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}