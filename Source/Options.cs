using System.Collections.Generic;
using BepInEx.Configuration;
using Nyxpiri.ULTRAKILL.NyxLib;

namespace Nyxpiri.ULTRAKILL.HeckPuppets
{
    public static class Options
    {
        public class HeckPuppetStyleEntry
        {
            public class HeckPuppetOptions
            {
                public ConfigEntry<int> NumHeckPuppets;
                public ConfigEntry<float> HeckPuppetDamageBuffScalar;
                public ConfigEntry<float> HeckPuppetSpeedBuffScalar;
                public ConfigEntry<float> HeckPuppetHealthBuffScalar;
                public ConfigEntry<float> HeckPuppetHealthScalar;
                public ConfigEntry<int> MaxHeckPuppetHealth;
                public ConfigEntry<float> RespawnDurationScalar;
            }

            public Dictionary<EnemyGameplayRank, HeckPuppetOptions> HeckPuppetsOptions = new Dictionary<EnemyGameplayRank, HeckPuppetOptions>();
        }
        
        public static ConfigEntry<float> HeckPuppetRespawnDuration = null;
        public static Dictionary<StyleRanks, HeckPuppetStyleEntry> HeckPuppetsStyleEntries = new Dictionary<StyleRanks, HeckPuppetStyleEntry>();

        public static void Initialize()
        {
            HeckPuppetRespawnDuration = Config.Bind($"Balance", "HeckPuppetRespawnDuration", 7.0f);

            HeckPuppetsStyleEntries = new Dictionary<StyleRanks, HeckPuppetStyleEntry>()
            {
                {
                    StyleRanks.Destructive, new HeckPuppetStyleEntry()
                    {
                        HeckPuppetsOptions = new Dictionary<EnemyGameplayRank, HeckPuppetStyleEntry.HeckPuppetOptions>
                        {
                            {
                                EnemyGameplayRank.Normal, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Destructive.Normal", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Destructive.Normal", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Destructive.Normal", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Destructive.Normal", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Destructive.Normal", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Destructive.Normal", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Miniboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Destructive.Miniboss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Destructive.Miniboss", "MinibossMaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Destructive.Miniboss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Destructive.Miniboss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Destructive.Miniboss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Destructive.Miniboss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Boss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Destructive.Boss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Destructive.Boss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Destructive.Boss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Destructive.Boss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Destructive.Boss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Destructive.Boss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Ultraboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Destructive.UltraBoss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Destructive.UltraBoss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Destructive.UltraBoss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Destructive.UltraBoss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Destructive.UltraBoss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Destructive.UltraBoss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                        }
                    }
                },
                {
                    StyleRanks.Chaotic, new HeckPuppetStyleEntry()
                    {
                        HeckPuppetsOptions = new Dictionary<EnemyGameplayRank, HeckPuppetStyleEntry.HeckPuppetOptions>
                        {
                            {
                                EnemyGameplayRank.Normal, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Chaotic.Normal", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Chaotic.Normal", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Chaotic.Normal", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Chaotic.Normal", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Chaotic.Normal", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Chaotic.Normal", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Miniboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Chaotic.Miniboss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Chaotic.Miniboss", "MinibossMaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Chaotic.Miniboss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Chaotic.Miniboss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Chaotic.Miniboss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Chaotic.Miniboss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Boss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Chaotic.Boss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Chaotic.Boss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Chaotic.Boss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Chaotic.Boss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Chaotic.Boss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Chaotic.Boss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Ultraboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Chaotic.UltraBoss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Chaotic.UltraBoss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Chaotic.UltraBoss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Chaotic.UltraBoss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Chaotic.UltraBoss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Chaotic.UltraBoss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                        }
                    }
                },
                {
                    StyleRanks.Brutal, new HeckPuppetStyleEntry()
                    {
                        HeckPuppetsOptions = new Dictionary<EnemyGameplayRank, HeckPuppetStyleEntry.HeckPuppetOptions>
                        {
                            {
                                EnemyGameplayRank.Normal, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Brutal.Normal", "NumHeckPuppets", 1),
                                    MaxHeckPuppetHealth = Config.Bind($"Brutal.Normal", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Brutal.Normal", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Brutal.Normal", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Brutal.Normal", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Brutal.Normal", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Miniboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Brutal.Miniboss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Brutal.Miniboss", "MinibossMaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Brutal.Miniboss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Brutal.Miniboss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Brutal.Miniboss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Brutal.Miniboss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Boss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Brutal.Boss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Brutal.Boss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Brutal.Boss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Brutal.Boss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Brutal.Boss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Brutal.Boss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Ultraboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Brutal.UltraBoss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Brutal.UltraBoss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Brutal.UltraBoss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Brutal.UltraBoss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Brutal.UltraBoss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Brutal.UltraBoss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                        }
                    }
                },
                {
                    StyleRanks.Anarchic, new HeckPuppetStyleEntry()
                    {
                        HeckPuppetsOptions = new Dictionary<EnemyGameplayRank, HeckPuppetStyleEntry.HeckPuppetOptions>
                        {
                            {
                                EnemyGameplayRank.Normal, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Anarchic.Normal", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Anarchic.Normal", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Anarchic.Normal", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Anarchic.Normal", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Anarchic.Normal", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Anarchic.Normal", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Miniboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Anarchic.Miniboss", "NumHeckPuppets", 1),
                                    MaxHeckPuppetHealth = Config.Bind($"Anarchic.Miniboss", "MinibossMaxHeckPuppetHealth", 14),
                                    HeckPuppetHealthScalar = Config.Bind($"Anarchic.Miniboss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Anarchic.Miniboss", "HeckPuppetHealthBuffScalar", 0.8f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Anarchic.Miniboss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Anarchic.Miniboss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Boss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Anarchic.Boss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Anarchic.Boss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Anarchic.Boss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Anarchic.Boss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Anarchic.Boss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Anarchic.Boss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Ultraboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Anarchic.UltraBoss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Anarchic.UltraBoss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Anarchic.UltraBoss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Anarchic.UltraBoss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Anarchic.UltraBoss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Anarchic.UltraBoss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                        }
                    }
                },
                {
                    StyleRanks.Supreme, new HeckPuppetStyleEntry()
                    {
                        HeckPuppetsOptions = new Dictionary<EnemyGameplayRank, HeckPuppetStyleEntry.HeckPuppetOptions>
                        {
                            {
                                EnemyGameplayRank.Normal, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Supreme.Normal", "NumHeckPuppets", 1),
                                    MaxHeckPuppetHealth = Config.Bind($"Supreme.Normal", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Supreme.Normal", "HeckPuppetHealthScalar", 0.76f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Supreme.Normal", "HeckPuppetHealthBuffScalar", 1.0f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Supreme.Normal", "HeckPuppetDamageBuffScalar", 0.75f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Supreme.Normal", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Miniboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Supreme.Miniboss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Supreme.Miniboss", "MinibossMaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Supreme.Miniboss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Supreme.Miniboss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Supreme.Miniboss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Supreme.Miniboss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Boss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Supreme.Boss", "NumHeckPuppets", 1),
                                    MaxHeckPuppetHealth = Config.Bind($"Supreme.Boss", "MaxHeckPuppetHealth", 14),
                                    HeckPuppetHealthScalar = Config.Bind($"Supreme.Boss", "HeckPuppetHealthScalar", 0.75f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Supreme.Boss", "HeckPuppetHealthBuffScalar", 0.8f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Supreme.Boss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Supreme.Boss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Ultraboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"Supreme.UltraBoss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"Supreme.UltraBoss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"Supreme.UltraBoss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"Supreme.UltraBoss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"Supreme.UltraBoss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"Supreme.UltraBoss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                        }
                    }
                },
                {
                    StyleRanks.SSadistic, new HeckPuppetStyleEntry()
                    {
                        HeckPuppetsOptions = new Dictionary<EnemyGameplayRank, HeckPuppetStyleEntry.HeckPuppetOptions>
                        {
                            {
                                EnemyGameplayRank.Normal, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"SSadistic.Normal", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"SSadistic.Normal", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"SSadistic.Normal", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"SSadistic.Normal", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"SSadistic.Normal", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"SSadistic.Normal", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Miniboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"SSadistic.Miniboss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"SSadistic.Miniboss", "MinibossMaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"SSadistic.Miniboss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"SSadistic.Miniboss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"SSadistic.Miniboss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"SSadistic.Miniboss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Boss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"SSadistic.Boss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"SSadistic.Boss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"SSadistic.Boss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"SSadistic.Boss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"SSadistic.Boss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"SSadistic.Boss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Ultraboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"SSadistic.UltraBoss", "NumHeckPuppets", 1),
                                    MaxHeckPuppetHealth = Config.Bind($"SSadistic.UltraBoss", "MaxHeckPuppetHealth", 20),
                                    HeckPuppetHealthScalar = Config.Bind($"SSadistic.UltraBoss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"SSadistic.UltraBoss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"SSadistic.UltraBoss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"SSadistic.UltraBoss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                        }
                    }
                },
                {
                    StyleRanks.SSSensoredStorm, new HeckPuppetStyleEntry()
                    {
                        HeckPuppetsOptions = new Dictionary<EnemyGameplayRank, HeckPuppetStyleEntry.HeckPuppetOptions>
                        {
                            {
                                EnemyGameplayRank.Normal, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"SSSensoredStorm.Normal", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"SSSensoredStorm.Normal", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"SSSensoredStorm.Normal", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"SSSensoredStorm.Normal", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"SSSensoredStorm.Normal", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"SSSensoredStorm.Normal", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Miniboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"SSSensoredStorm.Miniboss", "NumHeckPuppets", 1),
                                    MaxHeckPuppetHealth = Config.Bind($"SSSensoredStorm.Miniboss", "MinibossMaxHeckPuppetHealth", 20),
                                    HeckPuppetHealthScalar = Config.Bind($"SSSensoredStorm.Miniboss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"SSSensoredStorm.Miniboss", "HeckPuppetHealthBuffScalar", 0.75f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"SSSensoredStorm.Miniboss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"SSSensoredStorm.Miniboss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Boss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"SSSensoredStorm.Boss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"SSSensoredStorm.Boss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"SSSensoredStorm.Boss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"SSSensoredStorm.Boss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"SSSensoredStorm.Boss", "HeckPuppetDamageBuffScalar", 0.4f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"SSSensoredStorm.Boss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Ultraboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"SSSensoredStorm.UltraBoss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"SSSensoredStorm.UltraBoss", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"SSSensoredStorm.UltraBoss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"SSSensoredStorm.UltraBoss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"SSSensoredStorm.UltraBoss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"SSSensoredStorm.UltraBoss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                        }
                    }
                },
                {
                    StyleRanks.ULTRAKILL, new HeckPuppetStyleEntry()
                    {
                        HeckPuppetsOptions = new Dictionary<EnemyGameplayRank, HeckPuppetStyleEntry.HeckPuppetOptions>
                        {
                            {
                                EnemyGameplayRank.Normal, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"ULTRAKILL.Normal", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"ULTRAKILL.Normal", "MaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"ULTRAKILL.Normal", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"ULTRAKILL.Normal", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"ULTRAKILL.Normal", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"ULTRAKILL.Normal", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Miniboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"ULTRAKILL.Miniboss", "NumHeckPuppets", 0),
                                    MaxHeckPuppetHealth = Config.Bind($"ULTRAKILL.Miniboss", "MinibossMaxHeckPuppetHealth", 10),
                                    HeckPuppetHealthScalar = Config.Bind($"ULTRAKILL.Miniboss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"ULTRAKILL.Miniboss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"ULTRAKILL.Miniboss", "HeckPuppetDamageBuffScalar", 0.5f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"ULTRAKILL.Miniboss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Boss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"ULTRAKILL.Boss", "NumHeckPuppets", 1),
                                    MaxHeckPuppetHealth = Config.Bind($"ULTRAKILL.Boss", "MaxHeckPuppetHealth", 8),
                                    HeckPuppetHealthScalar = Config.Bind($"ULTRAKILL.Boss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"ULTRAKILL.Boss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"ULTRAKILL.Boss", "HeckPuppetDamageBuffScalar", 0.4f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"ULTRAKILL.Boss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                            {
                                EnemyGameplayRank.Ultraboss, new HeckPuppetStyleEntry.HeckPuppetOptions()
                                {
                                    NumHeckPuppets = Config.Bind($"ULTRAKILL.UltraBoss", "NumHeckPuppets", 1),
                                    MaxHeckPuppetHealth = Config.Bind($"ULTRAKILL.UltraBoss", "MaxHeckPuppetHealth", 8),
                                    HeckPuppetHealthScalar = Config.Bind($"ULTRAKILL.UltraBoss", "HeckPuppetHealthScalar", 0.5f),
                                    HeckPuppetHealthBuffScalar = Config.Bind($"ULTRAKILL.UltraBoss", "HeckPuppetHealthBuffScalar", 0.5f),
                                    HeckPuppetDamageBuffScalar = Config.Bind($"ULTRAKILL.UltraBoss", "HeckPuppetDamageBuffScalar", 0.4f),
                                    HeckPuppetSpeedBuffScalar = Config.Bind($"ULTRAKILL.UltraBoss", "HeckPuppetSpeedBuffScalar", 0.5f),
                                }
                            },
                        }
                    }
                },
            };
        }
        
        internal static ConfigFile Config = null;
    }
}