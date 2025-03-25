using System;
using Application.Core;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Persistance;

namespace Application.Activities.Queries;

public class GetActivitiesDetail
{
    public class Query : IRequest<Results<Activity>>
    {
        public required string Id { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Query, Results<Activity>>
    {
        public async Task<Results<Activity>> Handle(Query request, CancellationToken cancellationToken)
        {
            var activity = await context.Activities.FindAsync([request.Id], cancellationToken);

            if (activity == null) return Results<Activity>.Faliure("Activity not found", 404);

            return Results<Activity>.Success(activity);
        }
    }

}
