using System;
using System.Collections.Generic;

namespace BitbucketSharp.Models
{
    public class PullRequestModel
    {
		public ulong Id { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
		public string State { get; set; }
		public string Description { get; set; }
		public string Title { get; set; }
		public bool CloseSourceBranch { get; set; }
        public string Reason { get; set; }
        public TargetModel Source { get; set; }
        public TargetModel Destination { get; set; }
        public List<BitbucketSharp.Models.V2.UserModel> Reviewers { get; set; }
        public BitbucketSharp.Models.V2.UserModel Author { get; set; }
        public List<ParticipantModel> Participants { get; set; }

        public class ParticipantModel
        {
            public string Role { get; set; }
            public BitbucketSharp.Models.V2.UserModel User { get; set; }
            public bool Approved { get; set; }
        }

        public class TargetModel
        {
            public V2.RepositoryModel Repository { get; set; }
        }
    }

	public class PullRequestCommentModel
	{
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
		public ulong Id { get; set; }
		public ContentModel Content { get; set; }
        public InlineModel Inline { get; set; }
		public BitbucketSharp.Models.V2.UserModel User { get; set; }

		public class ContentModel
		{
			public string Raw { get; set; }
			public string Markup { get; set; }
			public string Html { get; set; }
		}

        public class InlineModel
        {
            public int? To { get; set; }
            public int? From { get; set; }
            public string Path { get; set; }
        }
	}

	public class OldPullRequestCommentModel
	{
		public string Username { get; set; }
		public string Content { get; set; }
		public string ContentRendered { get; set; }
	}

}

