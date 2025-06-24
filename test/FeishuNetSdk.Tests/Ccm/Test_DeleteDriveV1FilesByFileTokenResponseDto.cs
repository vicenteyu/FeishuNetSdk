// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteDriveV1FilesByFileTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除文件或文件夹 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 删除文件或文件夹 响应体
/// <para>接口ID：7029475705897828354</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteDriveV1FilesByFileTokenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "task_id": "7360595374803812356"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.DeleteDriveV1FilesByFileTokenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}