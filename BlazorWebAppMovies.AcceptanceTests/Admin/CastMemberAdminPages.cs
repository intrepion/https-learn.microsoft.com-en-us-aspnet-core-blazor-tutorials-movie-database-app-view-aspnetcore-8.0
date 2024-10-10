﻿using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace BlazorWebAppMovies.AcceptanceTests.Admin;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public partial class CastMemberAdminPages : PageTest
{
    [Test]
    public async Task MainNavigation()
    {
        await Expect(Page).ToHaveTitleAsync("Home");
        await Page.GetByRole(AriaRole.Link, new() { Name = "Cast Members" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Cast Member List");
        await Page.GetByRole(AriaRole.Link, new() { Name = "Create" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Cast Member Creation");

        await Page.GetByTestId("castMemberAdminEditName1").FillAsync("a castMember");
        await Page.GetByTestId("castMemberAdminEditName2").FillAsync("a castMember");
        // CreatePropertyCodePlaceholder
        // await Page.GetByTestId("castMemberAdminEditName").FillAsync("a castMember");

        await Page.GetByRole(AriaRole.Button, new() { Name = "Create" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Cast Member Modification");

        await Page.GetByTestId("castMemberAdminEditName1").FillAsync("some castMember");
        await Page.GetByTestId("castMemberAdminEditName2").FillAsync("some castMember");
        // ModifyPropertyCodePlaceholder
        // await Page.GetByTestId("castMemberAdminEditName").FillAsync("some castMember");

        await Page.GetByRole(AriaRole.Button, new() { Name = "Modify" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Cast Member Modification");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Remove" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Cast Member List");
    }

    [SetUp]
    public async Task SetUp()
    {
        await Page.GotoAsync("http://localhost:5137");
        await Page.GetByRole(AriaRole.Link, new() { Name = "Login" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Log in");
        await Page.GetByTestId("loginEmail").FillAsync("Admin1@BlazorWebAppMovies.com");
        await Page.GetByTestId("loginPassword").FillAsync("Admin1@BlazorWebAppMovies.com");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Log in" }).ClickAsync();
    }

    [TearDown]
    public async Task TearDown()
    {
        await Page.GetByRole(AriaRole.Button, new() { Name = "Logout" }).ClickAsync();
    }
}
