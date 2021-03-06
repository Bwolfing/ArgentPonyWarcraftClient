﻿using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class ProfessionApiTests
    {
        [Fact]
        public async void GetProfessionsIndexAsync_Gets_ProfessionsIndex()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/profession/index?namespace=static-us&locale=en_US",
                responseContent: Resources.ProfessionsIndexResponse);

            RequestResult<ProfessionsIndex> result = await warcraftClient.GetProfessionsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetProfessionAsync_Gets_Profession()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/profession/164?namespace=static-us&locale=en_US",
                responseContent: Resources.ProfessionResponse);

            RequestResult<Profession> result = await warcraftClient.GetProfessionAsync(164, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetProfessionMediaAsync_Gets_ProfessionMedia()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/media/profession/164?namespace=static-us&locale=en_US",
                responseContent: Resources.ProfessionMediaResponse);

            RequestResult<ProfessionMedia> result = await warcraftClient.GetProfessionMediaAsync(164, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetSkillTierAsync_Gets_SkillTier()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/profession/164/skill-tier/2477?namespace=static-us&locale=en_US",
                responseContent: Resources.SkillTierResponse);

            RequestResult<SkillTier> result = await warcraftClient.GetSkillTierAsync(164, 2477, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetRecipeAsync_Gets_Recipe()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/recipe/1631?namespace=static-us&locale=en_US",
                responseContent: Resources.RecipeResponse);

            RequestResult<Recipe> result = await warcraftClient.GetRecipeAsync(1631, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetRecipeMediaAsync_Gets_RecipeMedia()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/media/recipe/1631?namespace=static-us&locale=en_US",
                responseContent: Resources.RecipeMediaResponse);

            RequestResult<RecipeMedia> result = await warcraftClient.GetRecipeMediaAsync(1631, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
