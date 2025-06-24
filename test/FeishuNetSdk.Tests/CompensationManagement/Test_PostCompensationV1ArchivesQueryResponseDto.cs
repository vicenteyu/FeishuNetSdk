// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCompensationV1ArchivesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询员工薪资档案 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量查询员工薪资档案 响应体
/// <para>接口ID：7314129756769746948</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/archive/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2farchive%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1ArchivesQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "user_id": "344325234123",
                "id": "32141234412",
                "tid": "141541351",
                "plan_id": "123412433",
                "plan_tid": "213412343",
                "currency_id": "324167823",
                "change_reason_id": "321414123",
                "change_description": "长期表现优异，产出高，本次给出涨幅",
                "effective_date": "2022-10-23",
                "expiration_date": "2022-10-24",
                "salary_level_id": "12342313",
                "created_time": "2024-01-01 00:00:00",
                "updated_time": "2024-01-01 00:00:00",
                "archive_items": [
                    {
                        "item_id": "213423144",
                        "item_result": "15000",
                        "item_result_regular": "18000"
                    }
                ],
                "archive_indicators": [
                    {
                        "indicator_id": "23141423",
                        "indicator_result": "15000",
                        "indicator_result_regular": "18000"
                    }
                ]
            }
        ],
        "page_token": "1234452132",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.PostCompensationV1ArchivesQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}