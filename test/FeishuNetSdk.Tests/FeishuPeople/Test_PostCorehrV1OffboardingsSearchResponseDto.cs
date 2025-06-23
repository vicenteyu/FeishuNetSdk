namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 搜索离职信息 响应体
/// <para>接口ID：7211423970042183684</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1OffboardingsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "data": {
    "has_more": false,
    "items": [
      {
        "application_info": {
          "apply_finish_time": "2022-02-03 11:22:33",
          "apply_initiating_time": "2022-02-03 11:22:33",
          "apply_initiator_id": "6838119494196871234",
          "process_id": "6838119494196871234"
        },
        "initiating_type": "offboarding_directly",
        "offboarding_checklist": {
          "checklist_finish_time": "2022-02-03 11:22:33",
          "checklist_process_id": "6838119494196871234",
          "checklist_start_time": "2022-02-03 11:22:33",
          "checklist_status": "AntiBegin"
        },
        "offboarding_id": "7298499290417251879",
        "offboarding_info": {
          "add_block_list": "false",
          "block_reason": {
            "display": [
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              },
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              }
            ],
            "enum_name": "phone_type"
          },
          "block_reason_explanation": "xx 年 xx 月 xx 日因 xx 原因红线",
          "custom_fields": [
            {
              "custom_api_name": "name",
              "name": {
                "en_us": "Custom Name",
                "zh_cn": "自定义姓名"
              },
              "type": 1,
              "value": "\"231\""
            },
            {
              "custom_api_name": "name",
              "name": {
                "en_us": "Custom Name",
                "zh_cn": "自定义姓名"
              },
              "type": 1,
              "value": "\"231\""
            }
          ],
          "employee_reason": {
            "display": [
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              },
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              }
            ],
            "enum_name": "phone_type"
          },
          "employee_reason_explanation": "升学",
          "employment_id": "6893014062142064135",
          "enforce_noncompete_agreement": false,
          "expected_offboarding_date": "2022-02-08",
          "hrbp_id": [
            "6893014062142064135",
            "6893014062142064135"
          ],
          "is_transfer_with_workforce": false,
          "last_attendance_date": "2022-02-08",
          "noncompete_agreement_company": "123",
          "noncompete_agreement_end_date": "2022-02-08",
          "noncompete_agreement_id": "123",
          "noncompete_agreement_start_date": "2022-02-08",
          "offboarding_date": "2022-02-08",
          "provident_fund_end_date": "2022-02",
          "reason": {
            "display": [
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              },
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              }
            ],
            "enum_name": "phone_type"
          },
          "reason_explanation": "升学",
          "retain_account": false,
          "sign_type": {
            "display": [
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              },
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              }
            ],
            "enum_name": "phone_type"
          },
          "signature_file": "[\"123\",\"456\"]",
          "social_insurance_end_date": "2022-02"
        },
        "status": "Approving"
      },
      {
        "application_info": {
          "apply_finish_time": "2022-02-03 11:22:33",
          "apply_initiating_time": "2022-02-03 11:22:33",
          "apply_initiator_id": "6838119494196871234",
          "process_id": "6838119494196871234"
        },
        "initiating_type": "offboarding_directly",
        "offboarding_checklist": {
          "checklist_finish_time": "2022-02-03 11:22:33",
          "checklist_process_id": "6838119494196871234",
          "checklist_start_time": "2022-02-03 11:22:33",
          "checklist_status": "AntiBegin"
        },
        "offboarding_id": "7298499290417251879",
        "offboarding_info": {
          "add_block_list": "false",
          "block_reason": {
            "display": [
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              },
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              }
            ],
            "enum_name": "phone_type"
          },
          "block_reason_explanation": "xx 年 xx 月 xx 日因 xx 原因红线",
          "custom_fields": [
            {
              "custom_api_name": "name",
              "name": {
                "en_us": "Custom Name",
                "zh_cn": "自定义姓名"
              },
              "type": 1,
              "value": "\"231\""
            },
            {
              "custom_api_name": "name",
              "name": {
                "en_us": "Custom Name",
                "zh_cn": "自定义姓名"
              },
              "type": 1,
              "value": "\"231\""
            }
          ],
          "employee_reason": {
            "display": [
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              },
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              }
            ],
            "enum_name": "phone_type"
          },
          "employee_reason_explanation": "升学",
          "employment_id": "6893014062142064135",
          "enforce_noncompete_agreement": false,
          "expected_offboarding_date": "2022-02-08",
          "hrbp_id": [
            "6893014062142064135",
            "6893014062142064135"
          ],
          "is_transfer_with_workforce": false,
          "last_attendance_date": "2022-02-08",
          "noncompete_agreement_company": "123",
          "noncompete_agreement_end_date": "2022-02-08",
          "noncompete_agreement_id": "123",
          "noncompete_agreement_start_date": "2022-02-08",
          "offboarding_date": "2022-02-08",
          "provident_fund_end_date": "2022-02",
          "reason": {
            "display": [
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              },
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              }
            ],
            "enum_name": "phone_type"
          },
          "reason_explanation": "升学",
          "retain_account": false,
          "sign_type": {
            "display": [
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              },
              {
                "lang": "zh-CN",
                "value": "刘梓新"
              }
            ],
            "enum_name": "phone_type"
          },
          "signature_file": "[\"123\",\"456\"]",
          "social_insurance_end_date": "2022-02"
        },
        "status": "Approving"
      }
    ],
    "page_token": ""
  },
  "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1OffboardingsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}