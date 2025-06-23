namespace FeishuNetSdk.Tests.Acs;

/// <summary>
/// 测试 添加访客 请求体
/// <para>接口ID：7321978105899057180</para>
/// <para>文档地址：https://open.feishu.cn/document/acs-v1/visitor/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fvisitor%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAcsV1VisitorsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user": {
        "user_type": 11,
        "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
        "user_name": "张三",
        "phone_num": "1357890001",
        "department_id": "od-f7d44ab733f7602f5cc5194735fd9aaf"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Acs.PostAcsV1VisitorsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}