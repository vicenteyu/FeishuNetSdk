namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建导出任务 响应体
/// <para>接口ID：7089034521211191298</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/export_task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fexport_task%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1ExportTasksResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "ticket": "6933093124755423251"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1ExportTasksResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}