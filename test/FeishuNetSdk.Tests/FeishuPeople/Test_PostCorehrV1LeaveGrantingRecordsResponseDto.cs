// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1LeaveGrantingRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建假期发放记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建假期发放记录 响应体
/// <para>接口ID：7127187941650612227</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/leave/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave_granting_record%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1LeaveGrantingRecordsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "leave_granting_record": {
            "id": "6893014062142064135",
            "employment_id": "6893014062142064135",
            "leave_type_id": "6893014062142064135",
            "granting_quantity": "0.5",
            "granting_unit": 1,
            "effective_date": "2022-01-01",
            "expiration_date": "2022-01-01",
            "granted_by": 3,
            "reason": [
                {
                    "lang": "zh_CN",
                    "value": "张三"
                }
            ],
            "created_at": "1608725989000",
            "created_by": "646465654545",
            "updated_at": "1608725989000",
            "updated_by": "646465654545",
            "section_type": 1
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1LeaveGrantingRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}