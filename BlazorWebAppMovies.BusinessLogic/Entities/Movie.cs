﻿namespace ApplicationNamePlaceholder.BusinessLogic.Entities;

public class Movie
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
    public Guid Id { get; set; }

    public ICollection<CastMemberMovie> CastMemberMovies { get; set; } = [];
    // ActualPropertyPlaceholder
}
