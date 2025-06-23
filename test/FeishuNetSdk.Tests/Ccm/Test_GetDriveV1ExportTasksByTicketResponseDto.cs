namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 查询导出任务结果 响应体
/// <para>接口ID：7089034521211207682</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/export_task/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fexport_task%2fget</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1ExportTasksByTicketResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "result": {
            "file_extension": "pdf",
            "type": "doc",
            "file_name": "docName",
            "file_token": "boxcnxe5OdjlAkNgSNdsJvabcef",
            "file_size": 34356,
            "job_error_msg": "success",
            "job_status": 0
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1ExportTasksByTicketResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}