using AnonymousForum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic; // Make sure to include this for List<>
using System.Linq;
using Thread = AnonymousForum.Models.Thread;

namespace AnonymousForum.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AnonymousForumContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AnonymousForumContext>>()))
            {
                if (context.Topics.Any())
                {
                    return;   
                }

                var topics = new List<Topic>
                {
                    new Topic { TopicName = "Social Media" },
                    new Topic { TopicName = "Artificial Intelligence" },
                    new Topic { TopicName = "Space Exploration" },
                    new Topic { TopicName = "Neuroplasticity" }
                };

                context.Topics.AddRange(topics);
                context.SaveChanges();

                var threads = new List<Thread>
                {
                    // Social Media Threads
                    new Thread
                    {
                        ThreadTitle = "Social Media's Role in Mental Health",
                        ThreadDescription = "Discuss how social media affects our mental health and share strategies for mindful usage.",
                        FkTopicId = topics.First(t => t.TopicName == "Social Media").TopicId
                    },
                    new Thread
                    {
                        ThreadTitle = "Social Media and Business Growth",
                        ThreadDescription = "Share experiences and tips on leveraging social media for business expansion and customer engagement.",
                        FkTopicId = topics.First(t => t.TopicName == "Social Media").TopicId
                    },
                    
                    // Artificial Intelligence Threads
                    new Thread
                    {
                        ThreadTitle = "AI in Daily Life",
                        ThreadDescription = "Explore how AI impacts our daily routines and the subtle ways it enhances or challenges our day-to-day experiences.",
                        FkTopicId = topics.First(t => t.TopicName == "Artificial Intelligence").TopicId
                    },
                    new Thread
                    {
                        ThreadTitle = "Ethics of AI",
                        ThreadDescription = "Discuss the ethical considerations and moral implications of AI development and implementation.",
                        FkTopicId = topics.First(t => t.TopicName == "Artificial Intelligence").TopicId
                    },
                    new Thread
                    {
                        ThreadTitle = "AI in Healthcare",
                        ThreadDescription = "Delve into the advancements and controversies of AI in healthcare, from diagnostics to patient care innovations.",
                        FkTopicId = topics.First(t => t.TopicName == "Artificial Intelligence").TopicId
                    },
                    
                    // Space Exploration Threads
                    new Thread
                    {
                        ThreadTitle = "Life Beyond Earth",
                        ThreadDescription = "Explore the possibilities and latest findings related to extraterrestrial life, from microbes on Mars to exoplanets in the habitable zone.",
                        FkTopicId = topics.First(t => t.TopicName == "Space Exploration").TopicId
                    },
                    
                    // Neuroplasticity Threads
                    new Thread
                    {
                        ThreadTitle = "Brain Health & Neuroplasticity",
                        ThreadDescription = "Discuss strategies and activities that promote brain health and enhance neuroplasticity throughout different stages of life.",
                        FkTopicId = topics.First(t => t.TopicName == "Neuroplasticity").TopicId
                    }
                };

                context.Threads.AddRange(threads);
                context.SaveChanges();
            }
        }

        public static Account UserData()
        {
            Account account = new Account
            {
                Username = "login",
                Password = "123"
            };

            return account;
        }
    }
}
