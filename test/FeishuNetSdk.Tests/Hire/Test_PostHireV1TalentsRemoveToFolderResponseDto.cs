namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 将人才从指定文件夹移除 响应体
/// <para>接口ID：7418831232862617601</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/talent/remove_to_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fremove_to_folder</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentsRemoveToFolderResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "talent_id_list": [
            "7381815850065463596"
        ],
        "folder_id": "7039620186502138156"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1TalentsRemoveToFolderResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}