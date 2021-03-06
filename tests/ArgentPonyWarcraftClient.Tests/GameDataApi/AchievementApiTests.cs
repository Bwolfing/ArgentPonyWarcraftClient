﻿using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class AchievementApiTests
    {
        [Fact]
        public async void GetAchievementCategoriesIndexAsync_Gets_AchievementCategoriesIndex()
        {
            IAchievementApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/achievement-category/index?namespace=static-us&locale=en_US",
                responseContent: Resources.AchievementCategoriesIndexResponse);

            RequestResult<AchievementCategoriesIndex> result = await warcraftClient.GetAchievementCategoriesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetAchievementCategoryAsync_Gets_AchievementCategory()
        {
            IAchievementApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/achievement-category/81?namespace=static-us&locale=en_US",
                responseContent: Resources.AchievementCategoryResponse);

            RequestResult<AchievementCategory> result = await warcraftClient.GetAchievementCategoryAsync(81, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetAchievementsIndexAsync_Gets_AchievementsIndex()
        {
            IAchievementApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/achievement/index?namespace=static-us&locale=en_US",
                responseContent: Resources.AchievementsIndexResponse);

            RequestResult<AchievementsIndex> result = await warcraftClient.GetAchievementsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetAchievementAsync_Gets_Achievement()
        {
            IAchievementApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/achievement/6?namespace=static-us&locale=en_US",
                responseContent: Resources.GameDataAchievementResponse);

            RequestResult<Achievement> result = await warcraftClient.GetAchievementAsync(6, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetAchievementMediaAsync_Gets_AchievementMedia()
        {
            IAchievementApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/media/achievement/6?namespace=static-us&locale=en_US",
                responseContent: Resources.AchievementMediaResponse);

            RequestResult<AchievementMedia> result = await warcraftClient.GetAchievementMediaAsync(6, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
