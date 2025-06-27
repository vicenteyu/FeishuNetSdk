// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDriveV1FilesTaskCheckResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询异步任务状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 查询异步任务状态 响应体
/// <para>接口ID：7094912924435021826</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/async-task/task_check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2ftask_check</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1FilesTaskCheckResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "status": "success"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1FilesTaskCheckResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}