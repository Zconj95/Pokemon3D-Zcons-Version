Public Class AI

#Region "Enums"
    '''<summary>
    '''Represents A Wild Pokemon Decisions Made
    '''</summary>
    Public Enum WildAI
    
	'''<summary>
    '''Represents A Maximum Setting That States The Stage Of AI Difficulty Range Reaching 30
    '''</summary>	
        WildAILevelMax
        
	'''<summary>
    '''Represents A Minimum Setting That States The Stage Of AI Difficulty Range Reaching 0
    '''</summary>		
		WildAILevelMin
        
	'''<summary>
    '''Gives The Pokemon The Ability To Adapt And Learn About Each Opponents Move The More They Battle The Opponent And Make More Decisions Based Analysis Of Move Ranges
    '''</summary>		
		WildAIMoveAdaptation
        
	'''<summary>
    '''Grants The Skill For The Wild Pokemon To Dodge A Move And Increase Evasion 2 Stages Each Time The Pokemon Is Missed
    '''</summary>			
		WildAICanRun
        
	'''<summary>
    '''Grants The Skill For The Wild Pokemon To Dodge A Move And Increase Evasion 2 Stages Each Time The Pokemon Is Missed
    '''</summary>		
		WildAIEvasionIncrease
        
	'''<summary>
    '''Grants The Skill For The Wild Pokemon To Dodge A Move And Increase Evasion 2 Stages Each Time The Pokemon Is Missed 
    '''</summary>				
		WildAIAccuracyIncrease
        
	'''<summary>
    '''Sets The Value Of The Pokemon Difficulty
    '''</summary>		
		WildAIDifficulty
        
	'''<summary>
    '''EasyMode
    '''</summary>		
		WildAIEasyDifficulty
        
	'''<summary>
    '''MidRangeDifficulty
    '''</summary>		
		WildAIMediumDifficulty
        
	'''<summary>
    '''HardMode
    '''</summary>		
		WildAIHardDifficulty
        
	'''<summary>
    '''YouWillDie
    '''</summary>		
		WildAIInsaneDifficulty
        
	'''<summary>
    '''Welcome To My Nightmare
    '''</summary>		
		WildAINightmarishDifficulty
        
	'''<summary>
    '''Demigra Gooooooooo
    '''</summary>		
		WildAIDemiGodDifficulty
        
	'''<summary>
    '''A
    '''</summary>	
		WildAIPokemonGodDifficulty
        
	'''<summary>
    '''Represents A Wild Pokemon Capable Of Adapting Its Ability To Suit The Needs Of Battle When It First Enters Battle
    '''</summary>
		WildAIAbilityAdaptation

	'''<summary>
    '''Represents A Wild Pokemon Capable Hitting Max Default IV Limits Only As A Wild Pokemon In Battle
    '''</summary>
		WildAIIVIntensifier1
        
	'''<summary>
    '''Represents A Wild Pokemon Capable Tripling Default IV Limits Only As A Wild Pokemon In Battle
    '''</summary>
		WildAIIVIntensifier2
        
	'''<summary>
    '''Represents A Wild Pokemon Capable Of Having Adapting Its Nature Based On First Appearing Pokemon In Battle 
    '''</summary>
		WildAIIVNatureAdaptation
        
	'''<summary>
    '''Represents A Wild Pokemon Capable Of Increasing A Random Stat By 20% Value Until The End Of Battle
    '''</summary>	
		WildAIIVLuck
        
	'''<summary>
    '''Represents A Wild Pokemon Capable Of Advancing Its Move Sets To The Next Level For The Pokemon To Use More Powerful Moves Each Time It Beats The Players Pokemon
    '''</summary>
		WildAIMoveAdvancement
        
	'''<summary>
    '''Represents A Wild Pokemon Capable Of Obtaining And Holding Rare Items At a 20% Rate Of Chance Per Battle 
    '''</summary>	
		WildAIItemChanceIncrease
    
	'''<summary>
    '''Represents A Wild Pokemon Capable Of A 20% Chance To Dodge Any Move Each Turn 
    '''</summary>
		WildAIClaravoiance
    
	'''<summary>
    '''Represents A Wild Pokemon Capable Of Having A Default EV Minimum When Found Based On Default EV Limits
    '''</summary>		
		WildAIHiddenAbilityChanceIncrease
        
	'''<summary>
    '''Represents A Wild Pokemon Capable Of Reappearing With Better Stats Than Last Time And Higher AI Capabilities 
    '''</summary>		
		WildAIReappearingPokemonChance
        
	'''<summary>
    '''Represents A Wild Pokemon Capable Of Having A Skill To Endure A Critical Hit That Would Normally Kill The Creature
    '''</summary>			
		WildAICriticalEndurance
   
	'''<summary>
    '''Represents A Wild Pokemon Capable Of Having A Skill To Endure Any Hit That Would Normally Kill The Creature
    '''</summary>	
		WildAIEndurance
   
	'''<summary>
    '''Represents A Wild Pokemon Capable Of Having A Default IV When Found Based On Default IV Maximum And Minimum Limits
    '''</summary>			
		WildAIDefaultIVSetupClass
        
	'''<summary>
    '''Represents A Wild Pokemon Capable Of 15% Value Of Producing A Critical Hit The Longer It Lasts In Battle For Every 3 Turns
    '''</summary>	
		WildAIMoveCritChance
        
	'''<summary>
    '''Represents A Wild Pokemon Capable Of Having A Default EV Minimum When Found Based On Default EV Maximum Limits
    '''</summary>			
		WildAIDefaultEVMin

	'''<summary>
    '''Represents A Wild Pokemon Capable Of Having A Default EV Maximum When Found Based On Default EV Maximum Limits
    '''</summary>	
		WildAIDefaultEVMax

	'''<summary>
    '''
    '''</summary>
		WildAIDefaultCatchLevelOverload