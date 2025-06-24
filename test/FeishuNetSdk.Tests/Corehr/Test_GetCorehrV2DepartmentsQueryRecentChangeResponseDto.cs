// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV2DepartmentsQueryRecentChangeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询生效信息变更部门 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询生效信息变更部门 响应体
/// <para>接口ID：7414100499044646940</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/query_recent_change</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fquery_recent_change</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2DepartmentsQueryRecentChangeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "department_ids": [
            "7094136522860922111"
        ],
        "deleted_department_ids": [
            "7094136522860922111"
        ],
        "page_token": "7094136522860922111",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2DepartmentsQueryRecentChangeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}