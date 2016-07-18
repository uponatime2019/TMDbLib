﻿using Xunit;
using TMDbLib.Objects.Reviews;
using TMDbLib.Objects.General;
using TMDbLibTests.Helpers;
using TMDbLibTests.JsonHelpers;

namespace TMDbLibTests
{
    public class ClientReviewTests : TestBase
    {
        private readonly TestConfig _config;

        public ClientReviewTests()
        {
            _config = new TestConfig();
        }

        [Fact]
        public void TestReviewFullDetails()
        {
            Review review = _config.Client.GetReviewAsync(IdHelper.TheDarkKnightRisesReviewId).Result;

            Assert.NotNull(review);

            Assert.Equal(IdHelper.TheDarkKnightRisesReviewId, review.Id);
            Assert.Equal(49026, review.MediaId);
            Assert.Equal("The Dark Knight Rises", review.MediaTitle);
            Assert.Equal("Travis Bell", review.Author);
            Assert.Equal("en", review.Iso_639_1);
            Assert.Equal("https://www.themoviedb.org/review/5010553819c2952d1b000451", review.Url);
            Assert.Equal(MediaType.Movie, review.MediaType);
        }
    }
}
