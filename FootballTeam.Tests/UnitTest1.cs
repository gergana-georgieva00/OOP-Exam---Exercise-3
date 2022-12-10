using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FootballTeam.Tests
{
    public class Tests
    {
        FootballPlayer player;
        FootballTeam team;

        [SetUp]
        public void Setup()
        {
            player = new FootballPlayer("playerName", 7, "Goalkeeper");
            team = new FootballTeam("teamName", 15);
        }

        [Test]
        public void NameGetter()
        {
            Assert.That(team.Name, Is.EqualTo("teamName"));
        }

        [Test]
        public void NameNotNull()
        {
            Assert.Throws<ArgumentException>(() => team = new FootballTeam(null, 15));
            Assert.Throws<ArgumentException>(() => team = new FootballTeam("", 15));
        }

        [Test]
        public void CapacityGetter()
        {
            Assert.That(team.Capacity, Is.EqualTo(15));
        }

        [Test]
        public void CapacityLessThan15()
        {
            Assert.Throws<ArgumentException>(() => team = new FootballTeam("name", 10));
        }

        [Test]
        public void PlayersGetter()
        {
            var players = new List<FootballPlayer>() { player };
            team.AddNewPlayer(player);
            Assert.That(team.Players, Is.EqualTo(players));
        }

        [Test]
        public void AddNewWithFilledCapacity()
        {
            
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));

            Assert.That(team.AddNewPlayer(player), Is.EqualTo("No more positions available!"));
            Assert.That(team.Players.Count, Is.EqualTo(15));
        }

        [Test]
        public void AddPlayerReturns()
        {
            Assert.That(team.AddNewPlayer(player), Is.EqualTo($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}"));
            Assert.That(team.Players.Count, Is.EqualTo(1));
        }

        [Test]
        public void AddPlayerThows()
        {
            Assert.Throws<ArgumentException>(() => team.AddNewPlayer(new FootballPlayer(null, 4, "Goalkeeper")));
            Assert.Throws<ArgumentException>(() => team.AddNewPlayer(new FootballPlayer("name", -1, "Goalkeeper")));
            Assert.Throws<ArgumentException>(() => team.AddNewPlayer(new FootballPlayer("name", 4, "Position")));
        }

        [Test]
        public void PickPlayerWorks()
        {
            team.AddNewPlayer(player);
            Assert.That(team.PickPlayer("playerName"), Is.EqualTo(player));
        }

        [Test]
        public void PickPlayerWorks2()
        {
            Assert.That(team.PickPlayer("playerName"), Is.EqualTo(null));
        }

        [Test]
        public void PlayerScoreWorks()
        {
            team.AddNewPlayer(player);
            Assert.That(team.PlayerScore(7), Is.EqualTo($"{player.Name} scored and now has {player.ScoredGoals} for this season!"));
            Assert.That(player.ScoredGoals, Is.EqualTo(1));
        }
    }
}