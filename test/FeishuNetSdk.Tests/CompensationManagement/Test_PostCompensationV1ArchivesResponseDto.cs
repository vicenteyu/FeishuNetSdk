// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-10
//
// Last Modified By : yxr
// Last Modified On : 2025-09-10
// ************************************************************************
// <copyright file="Test_PostCompensationV1ArchivesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建薪资档案 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 创建薪资档案 响应体
/// <para>接口ID：7451269641491939329</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/archive/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2farchive%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1ArchivesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "unique_id": "123e4567-e89b-42d3-a456-426614174000",
        "archive_tid": "7434007780111336970"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.PostCompensationV1ArchivesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}