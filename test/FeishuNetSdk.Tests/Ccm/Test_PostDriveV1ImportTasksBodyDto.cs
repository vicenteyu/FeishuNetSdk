// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDriveV1ImportTasksBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建导入任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建导入任务 请求体
/// <para>接口ID：6987581325629947905</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/import_task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fimport_task%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1ImportTasksBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "file_extension": "xlsx",
    "file_token": "boxcnrHpsg1QDqXAAAyachabcef",
    "type": "sheet",
    "file_name": "销售表",
    "point": {
        "mount_type": 1,
        "mount_key": "AbqrfuRTjlJEIJduwDwcnIabcef"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1ImportTasksBodyDto>(json);
        Assert.IsNotNull(result);
    }
}