// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDriveV1ImportTasksByTicketResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询导入任务结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 查询导入任务结果 响应体
/// <para>接口ID：6987581325629931521</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/import_task/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fimport_task%2fget</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1ImportTasksByTicketResponseDto : TestBase
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
            "ticket": "7369583175086912356",
            "type": "sheet",
            "job_status": 0,
            "job_error_msg": "success",
            "token": "Fm7osyjtMh5o7Ktrv32c73abcef",
            "url": "https://example.feishu.cn/sheets/Fm7osyjtMh5o7Ktrv32c73abcef",
            "extra": [
                "2000"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1ImportTasksByTicketResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}