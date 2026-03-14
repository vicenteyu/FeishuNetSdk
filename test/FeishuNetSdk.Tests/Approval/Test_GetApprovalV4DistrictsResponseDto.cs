// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-14
//
// Last Modified By : yxr
// Last Modified On : 2026-03-14
// ************************************************************************
// <copyright file="Test_GetApprovalV4DistrictsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询地理库信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 查询地理库信息 响应体
/// <para>接口ID：7579169568158518477</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/district/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fdistrict%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApprovalV4DistrictsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "version": "7569941109133377539",
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "items": [
            {
                "id": "2038349",
                "name": "Beijing",
                "level": "Province",
                "has_sub_district": false,
                "parent_districts": [
                    {
                        "id": "1814991",
                        "name": "China",
                        "level": "Country"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.GetApprovalV4DistrictsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}