// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDriveV1ExportTasksBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建导出任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建导出任务 请求体
/// <para>接口ID：7089034521211191298</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/export_task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fexport_task%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1ExportTasksBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "file_extension": "csv",
    "token": "Fm7osyjtMh5o7Ktrv32c73abcef",
    "type": "sheet",
    "sub_id": "6e5ed3"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1ExportTasksBodyDto>(json);
        Assert.IsNotNull(result);
    }
}