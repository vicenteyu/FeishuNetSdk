namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取绩效结果 响应体
/// <para>接口ID：7000193886257725441</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/performance-v1/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2freview_data%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV1ReviewDatasQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "data": {
    "activities": [
      {
        "id": "6992035450862323244",
        "name": {
          "en-US": "",
          "zh-CN": "rino"
        },
        "semester_id": "6992035450862224940"
      }
    ],
    "datas": [
      {
        "activity_id": "6992035450862323244",
        "semester_id": "6992035450862224940",
        "stages": [
          {
            "data": [
              {
                "field_id": "6982759009698137641",
                "reviewer_user_id": {
                  "open_id": "ou_f0ff33850fc47236e34360d5eed99405",
                  "user_id": "6924863940618878996"
                },
                "submit_time": "1627977114000",
                "template_id": "6982759008972326447",
                "text": "干得不错",
                "richtext": "{\"ops\":[{\"name\":\"insert\",\"text\":\"干得不错\"}]}",
                "unit_id": "6982759008973882926"
              }
            ],
            "progress": 3,
            "stage_type": "communication_and_open_result"
          },
          {
            "data": [
              {
                "field_id": "6982759006887888417",
                "indicator_id": "6966127279593784876",
                "option_id": "6966127279593653804",
                "reviewer_user_id": {
                  "open_id": "ou_f0ff33850fc47236e34360d5eed99405",
                  "user_id": "6924863940618878996"
                },
                "submit_time": "1627977100000",
                "template_id": "6982759008789366313",
                "unit_id": "6982759009396508196"
              },
              {
                "field_id": "6982759010081818159",
                "reviewer_user_id": {
                  "open_id": "ou_f0ff33850fc47236e34360d5eed99405",
                  "user_id": "6924863940618878996"
                },
                "submit_time": "1627977100000",
                "template_id": "6982759008789366313",
                "text": "nice",
                "richtext": "{\"ops\":[{\"name\":\"insert\",\"text\":\"nice\"}]}",
                "unit_id": "6982759009396508196"
              },
              {
                "field_id": "6982759007539463717",
                "reviewer_user_id": {
                  "open_id": "ou_f0ff33850fc47236e34360d5eed99405",
                  "user_id": "6924863940618878996"
                },
                "submit_time": "1627977100000",
                "template_id": "6982759008789366313",
                "text": "bad",
                "richtext": "{\"ops\":[{\"name\":\"insert\",\"text\":\"bad\"}]}",
                "unit_id": "6982759009396508196"
              },
              {
                "field_id": "6982759008811615782",
                "indicator_id": "6966168074268280364",
                "option_id": "6966127279593686572",
                "reviewer_user_id": {
                  "open_id": "ou_f0ff33850fc47236e34360d5eed99405",
                  "user_id": "6924863940618878996"
                },
                "submit_time": "1627977100000",
                "template_id": "6982759008789366313",
                "unit_id": "6982759008043877922"
              },
              {
                "field_id": "6982759010112800295",
                "reviewer_user_id": {
                  "open_id": "ou_f0ff33850fc47236e34360d5eed99405",
                  "user_id": "6924863940618878996"
                },
                "submit_time": "1627977100000",
                "template_id": "6982759008789366313",
                "text": "字节范不错",
                "richtext": "{\"ops\":[{\"name\":\"insert\",\"text\":\"字节范不错\"}]}",
                "unit_id": "6982759008043877922"
              },
              {
                "field_id": "6982759009719158315",
                "indicator_id": "6966164187820820012",
                "option_id": "6966127279593621036",
                "reviewer_user_id": {
                  "open_id": "ou_f0ff33850fc47236e34360d5eed99405",
                  "user_id": "6924863940618878996"
                },
                "submit_time": "1627977100000",
                "template_id": "6982759008789366313",
                "unit_id": "6982759010462647852"
              },
              {
                "field_id": "6982759006797776417",
                "reviewer_user_id": {
                  "open_id": "ou_f0ff33850fc47236e34360d5eed99405",
                  "user_id": "6924863940618878996"
                },
                "submit_time": "1627977100000",
                "template_id": "6982759008789366313",
                "text": "与公司共同发展",
                "richtext": "{\"ops\":[{\"name\":\"insert\",\"text\":\"与公司共同发展\"}]}",
                "unit_id": "6982759010462647852"
              },
              {
                "field_id": "7374030018090418179",
                "indicator_id": "",
                "option_id": "",
                "perf_coefficient_result": "4.00",
                "reviewer_user_id": {
                  "open_id": "ou_4cced6778e381ff987855095d546be82",
                  "user_id": "7312059639540072452"
                },
                "score": "",
                "submit_time": "1716900660000",
                "template_id": "7374030018090106883",
                "text": "",
                "richtext": "{\"ops\":[{\"name\":\"insert\",\"text\":\"\"}]}",
                "unit_id": "7374030018090336259"
              }
            ],
            "progress": 3,
            "stage_type": "leader_review"
          }
        ],
        "user_id": {
          "open_id": "ou_3245842393d09e9428ad4655da6e30b3",
          "user_id": "6932009399175086099"
        }
      }
    ],
    "fields": [
      {
        "id": "6982759008811615782",
        "name": {
          "en-US": "",
          "zh-CN": "价值观"
        }
      },
      {
        "id": "6982759010112800295",
        "name": {
          "en-US": "",
          "zh-CN": "价值观评语"
        }
      },
      {
        "id": "6982759008504284709",
        "name": {
          "en-US": "",
          "zh-CN": ""
        }
      },
      {
        "id": "6982759009698137641",
        "name": {
          "en-US": "",
          "zh-CN": "最终反馈"
        }
      },
      {
        "id": "6982759006887888417",
        "name": {
          "en-US": "",
          "zh-CN": "业绩"
        }
      },
      {
        "id": "6982759010081818159",
        "name": {
          "en-US": "",
          "zh-CN": "做得好的"
        }
      },
      {
        "id": "6982759007539463717",
        "name": {
          "en-US": "",
          "zh-CN": "待改进的"
        }
      },
      {
        "id": "6982759009072072239",
        "name": {
          "en-US": "",
          "zh-CN": "留言"
        }
      },
      {
        "id": "6982759009719158315",
        "name": {
          "en-US": "",
          "zh-CN": "投入度"
        }
      },
      {
        "id": "6982759006797776417",
        "name": {
          "en-US": "",
          "zh-CN": "投入度评语"
        }
      }
    ],
    "indicators": [
      {
        "id": "6966127279593784876",
        "name": {
          "en-US": "",
          "zh-CN": "业绩"
        },
        "options": [
          {
            "id": "6966127279593588268",
            "label": "D",
            "name": {
              "en-US": "",
              "zh-CN": "不符预期"
            }
          },
          {
            "id": "6966127279593621036",
            "label": "C",
            "name": {
              "en-US": "",
              "zh-CN": "略低预期"
            }
          },
          {
            "id": "6966127279593653804",
            "label": "B",
            "name": {
              "en-US": "",
              "zh-CN": "符合预期"
            }
          },
          {
            "id": "6966127279593686572",
            "label": "A",
            "name": {
              "en-US": "",
              "zh-CN": "略超预期"
            }
          },
          {
            "id": "6966127279593719340",
            "label": "S",
            "name": {
              "en-US": "",
              "zh-CN": "远超预期"
            }
          }
        ]
      },
      {
        "id": "6966164187820820012",
        "name": {
          "en-US": "",
          "zh-CN": "投入度"
        },
        "options": [
          {
            "id": "6966127279593588268",
            "label": "D",
            "name": {
              "en-US": "",
              "zh-CN": "不符预期"
            }
          },
          {
            "id": "6966127279593621036",
            "label": "C",
            "name": {
              "en-US": "",
              "zh-CN": "略低预期"
            }
          },
          {
            "id": "6966127279593653804",
            "label": "B",
            "name": {
              "en-US": "",
              "zh-CN": "符合预期"
            }
          },
          {
            "id": "6966127279593686572",
            "label": "A",
            "name": {
              "en-US": "",
              "zh-CN": "略超预期"
            }
          },
          {
            "id": "6966127279593719340",
            "label": "S",
            "name": {
              "en-US": "",
              "zh-CN": "远超预期"
            }
          }
        ]
      },
      {
        "id": "6966168074268280364",
        "name": {
          "en-US": "",
          "zh-CN": "价值观"
        },
        "options": [
          {
            "id": "6966127279593588268",
            "label": "D",
            "name": {
              "en-US": "",
              "zh-CN": "不符预期"
            }
          },
          {
            "id": "6966127279593621036",
            "label": "C",
            "name": {
              "en-US": "",
              "zh-CN": "略低预期"
            }
          },
          {
            "id": "6966127279593653804",
            "label": "B",
            "name": {
              "en-US": "",
              "zh-CN": "符合预期"
            }
          },
          {
            "id": "6966127279593686572",
            "label": "A",
            "name": {
              "en-US": "",
              "zh-CN": "略超预期"
            }
          },
          {
            "id": "6966127279593719340",
            "label": "S",
            "name": {
              "en-US": "",
              "zh-CN": "远超预期"
            }
          }
        ]
      }
    ],
    "semesters": [
      {
        "end_time": "1640966399999",
        "id": "6992035450862224940",
        "name": {
          "en-US": "",
          "zh-CN": "sr"
        },
        "start_time": "1625068800000"
      }
    ],
    "templates": [
      {
        "id": "6982759007063000610",
        "name": {
          "en-US": "Release and Communicate Performance Review with Direct Reports",
          "zh-CN": "进行直属下级绩效沟通并开通结果"
        },
        "stage": "communication_and_open_result"
      },
      {
        "id": "6982759008113116716",
        "name": {
          "en-US": "Manager Review",
          "zh-CN": "上级评估"
        },
        "stage": "leader_review"
      },
      {
        "id": "6982759008537495079",
        "name": {
          "en-US": "Release and Communicate Performance Review with Direct Reports",
          "zh-CN": "进行直属下级绩效沟通并开通结果"
        },
        "stage": "communication_and_open_result"
      },
      {
        "id": "6982759008789366313",
        "name": {
          "en-US": "Manager Review",
          "zh-CN": "上级评估"
        },
        "stage": "leader_review"
      },
      {
        "id": "6982759008959153708",
        "name": {
          "en-US": "Release and Communicate Performance Review with Direct Reports",
          "zh-CN": "进行直属下级绩效沟通并开通结果"
        },
        "stage": "communication_and_open_result"
      },
      {
        "id": "6982759008972326447",
        "name": {
          "en-US": "Release and Communicate Performance Review with Direct Reports",
          "zh-CN": "进行直属下级绩效沟通并开通结果"
        },
        "stage": "communication_and_open_result"
      },
      {
        "id": "6982759010376304165",
        "name": {
          "en-US": "Manager Review",
          "zh-CN": "上级评估"
        },
        "stage": "leader_review"
      },
      {
        "id": "6982759010524038691",
        "name": {
          "en-US": "Manager Review",
          "zh-CN": "上级评估"
        },
        "stage": "leader_review"
      },
      {
        "id": "6982759010669463083",
        "name": {
          "en-US": "Release and Communicate Performance Review with Direct Reports",
          "zh-CN": "进行直属下级绩效沟通并开通结果"
        },
        "stage": "communication_and_open_result"
      }
    ],
    "units": [
      {
        "id": "6982759008043877922",
        "name": {
          "en-US": "",
          "zh-CN": "价值观"
        }
      },
      {
        "id": "6982759008607602222",
        "name": {
          "en-US": "",
          "zh-CN": "重点工作"
        }
      },
      {
        "id": "6982759008973882926",
        "name": {
          "en-US": "",
          "zh-CN": "最终反馈"
        }
      },
      {
        "id": "6982759009396508196",
        "name": {
          "en-US": "",
          "zh-CN": "业绩"
        }
      },
      {
        "id": "6982759010063910445",
        "name": {
          "en-US": "",
          "zh-CN": "留言"
        }
      },
      {
        "id": "6982759010462647852",
        "name": {
          "en-US": "",
          "zh-CN": "投入度"
        }
      }
    ]
  },
  "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV1ReviewDatasQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}