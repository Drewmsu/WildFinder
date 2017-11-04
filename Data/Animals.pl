:- dynamic animal_habitat/2.
:- dynamic animal_class/2.
:- dynamic habitat_biome/2.
:- dynamic habitat_class/2.
:- dynamic animal_enemy/2.
:- dynamic animal_biome/2.

%ANIMAL_HABITAT
animal_habitat(frog_bull,aquatic).
animal_habitat(frog_cuban,terrestrial).
animal_habitat(frog_leopard,aquatic).
animal_habitat(hellbender,aquatic).
animal_habitat(salamander_japanese,aquatic).
animal_habitat(salamander_tiger,terrestrial).
animal_habitat(toad_american,terrestrial).
animal_habitat(buzzard,terrestrial).
animal_habitat(canary,terrestrial).
animal_habitat(chicken,terrestrial).
animal_habitat(crow_hooded,terrestrial).
animal_habitat(duck_mallard,aquatic).
animal_habitat(duck_wood,aquatic).
animal_habitat(european_jackdaw,terrestrial).
animal_habitat(falcon_peregrin,terrestrial).
animal_habitat(goshawk,terrestrial).
animal_habitat(guinea_fowl,terrestrial).
animal_habitat(gull_herring,terrestrial).
animal_habitat(gull_herring,marine).
animal_habitat(hawk_night,terrestrial).
animal_habitat(hummingbird,terrestrial).
animal_habitat(hummingbird_cuban_bee,terrestrial).
animal_habitat(kestrel_lesser,terrestrial).
animal_habitat(kiwi,terrestrial).
animal_habitat(magpie_black_billed,terrestrial).
animal_habitat(ostrich,terrestrial).
animal_habitat(penguin_adelie,marine).
animal_habitat(pheasant_ringnecked,terrestrial).
animal_habitat(pigeon,terrestrial).
animal_habitat(quail_bobwhite,terrestrial).
animal_habitat(quail_japanese_european,terrestrial).
animal_habitat(robin,terrestrial).
animal_habitat(rook,terrestrial).
animal_habitat(starling_common,terrestrial).
animal_habitat(turkey,terrestrial).
animal_habitat(vulture_turkey,terrestrial).
animal_habitat(skate,marine).
animal_habitat(sea_lamprey,marine).
animal_habitat(sea_lamprey,aquatic).
animal_habitat(dogfish_pacific_spiny,marine).
animal_habitat(shark_hammerhead,marine).
animal_habitat(shark_whale,marine).
animal_habitat(sting_ray,marine).
animal_habitat(armadillo_nine_banded,terrestrial).
animal_habitat(bat_flying_fox,terrestrial).
animal_habitat(bat_little_brown,terrestrial).
animal_habitat(bear_american_black,terrestrial).
animal_habitat(bear_grizzly,terrestrial).
animal_habitat(beaver,aquatic).
animal_habitat(camel,terrestrial).
animal_habitat(cat_domestic,terrestrial).
animal_habitat(chipmunk_eastern,terrestrial).
animal_habitat(cow,terrestrial).
animal_habitat(deer_white_tailed,terrestrial).
animal_habitat(dog_basset_hound,terrestrial).
animal_habitat(dog_beagle,terrestrial).
animal_habitat(dog_boston_terrier,terrestrial).
animal_habitat(dog_collie,terrestrial).
animal_habitat(dog_fox_terrier,terrestrial).
animal_habitat(dog_foxhound,terrestrial).
animal_habitat(dog_irish_terrier,terrestrial).
animal_habitat(dog_pekingese,terrestrial).
animal_habitat(dog_pointer,terrestrial).
animal_habitat(dog_saint_bernard,terrestrial).
animal_habitat(dog_whippet,terrestrial).
animal_habitat(dolphin_bottlenose,marine).
animal_habitat(donkey,terrestrial).
animal_habitat(elephant_african,terrestrial).
animal_habitat(elephant_indian,terrestrial).
animal_habitat(fox_arctic,terrestrial).
animal_habitat(giraffe_male,terrestrial).
animal_habitat(goat_milch,terrestrial).
animal_habitat(guinea_pig,terrestrial).
animal_habitat(hamster,terrestrial).
animal_habitat(horse,terrestrial).
animal_habitat(human,terrestrial).
animal_habitat(kangaroo_red,terrestrial).
animal_habitat(lion,terrestrial).
animal_habitat(manatee,marine).
animal_habitat(manatee,aquatic).
animal_habitat(mink_american,terrestrial).
animal_habitat(mouse_house,terrestrial).
animal_habitat(mouse_white-footed,terrestrial).
animal_habitat(mule,terrestrial).
animal_habitat(nutria,terrestrial).
animal_habitat(opossum_large_american,terrestrial).
animal_habitat(pig,terrestrial).
animal_habitat(platypus_duck_billed,aquatic).
animal_habitat(porcupine,terrestrial).
animal_habitat(rabbit_domestic,terrestrial).
animal_habitat(rat_norway,terrestrial).
animal_habitat(seal_fur,marine).
animal_habitat(sheep,terrestrial).
animal_habitat(shrew_dwarf,terrestrial).
animal_habitat(shrew_musked,terrestrial).
animal_habitat(squirrel_gray,terrestrial).
animal_habitat(tapir,terrestrial).
animal_habitat(weasel_least,terrestrial).
animal_habitat(whale_blue,marine).
animal_habitat(woodchuck,terrestrial).
animal_habitat(groundhog,terrestrial).
animal_habitat(tuna,marine).
animal_habitat(bass_large_mouth_black,aquatic).
animal_habitat(bass_rock,aquatic).
animal_habitat(bullhead_brown,aquatic).
animal_habitat(carp,aquatic).
animal_habitat(eel_american,marine).
animal_habitat(eel_american,aquatic).
animal_habitat(fighting_fish_siamese,aquatic).
animal_habitat(flounder_winter,marine).
animal_habitat(gar_longnose,aquatic).
animal_habitat(guppy,aquatic).
animal_habitat(haddock,marine).
animal_habitat(herring_atlantic,marine).
animal_habitat(mackerel_spanish,marine).
animal_habitat(molly,aquatic).
animal_habitat(perch,aquatic).
animal_habitat(pike_northern,aquatic).
animal_habitat(pumpkinseed,aquatic).
animal_habitat(salmon_chum,marine).
animal_habitat(salmon_chum,aquatic).
animal_habitat(sea_horse,marine).
animal_habitat(stickleback_three_spine,aquatic).
animal_habitat(sturgeon_atlantic,aquatic).
animal_habitat(sturgeon_atlantic,marine).
animal_habitat(swordtail_mexican,aquatic).
animal_habitat(trout_brown,aquatic).
animal_habitat(trout_rainbow,aquatic).
animal_habitat(cod_atlantic,marine).
animal_habitat(goby_philippine,marine).
animal_habitat(goldfish,aquatic).
animal_habitat(alligator_american,aquatic).
animal_habitat(boa_constrictor,terrestrial).
animal_habitat(chameleon,terrestrial).
animal_habitat(chameleon_madagascar,terrestrial).
animal_habitat(cobra_indian,terrestrial).
animal_habitat(rocodile_saltwater,marine).
animal_habitat(gila_monster,terrestrial).

%ANIMAL_BIOME
animal_biome(seal_fur, arctic	).
animal_biome(penguin_adelie,	arctic_waters	).
animal_biome(bat_little_brown,	barns 	).
animal_biome(bat_little_brown,	bcaves	).
animal_biome(manatee,	bays	).
animal_biome(flounder_winter,	bays_shallow	).
animal_biome(stickleback_three_spine,	brooks	).
animal_biome(fox_arctic	,	coastline_arctic	).
animal_biome(cod_atlantic,	coastline_atlantic	).
animal_biome(gila_monster,	desert	).
animal_biome(ostrich,	desert_africa	).
animal_biome(camel,	desert_africa ).
animal_biome(camel,	mid_east_asia).
animal_biome(cat_domestic,	domestic	).
animal_biome(chicken,	domestic	).
animal_biome(dog_boston_terrier	,	domestic	).
animal_biome(dog_collie,	domestic	).
animal_biome(dog_foxhound	,	domestic	).
animal_biome(dog_irish_terrier	,	domestic	).
animal_biome(dog_pekingese	,	domestic	).
animal_biome(dog_pointer	,	domestic	).
animal_biome(dog_saint_bernard	,	domestic	).
animal_biome(dog_whippet	,	domestic	).
animal_biome(donkey	,	domestic	).
animal_biome(goat_milch	,	domestic	).
animal_biome(guinea_pig	,	domestic	).
animal_biome(horse	,	domestic	).
animal_biome(mule	,	domestic	).
animal_biome(rabbit_domestic	,	domestic	).
animal_biome(sheep	,	domestic	).
animal_biome(vulture_turkey	,	fields_open	).
animal_biome(shrew_musked	,	forest).
animal_biome(shrew_musked	, brushland	).
animal_biome(bear_grizzly	,	forest_coniferous	).
animal_biome(squirrel_gray	,	forest_pine ).
animal_biome(squirrel_gray	,	forest_hardwood ).
animal_biome(squirrel_gray	,	trees_nut).
animal_biome(squirrel_gray	,	river_bottoms	).
animal_biome(frog_cuban	,	forest_rain	).
animal_biome(deer_white_tailed	,	forests	).
animal_biome(deer_white_tailed	,	swamps	).
animal_biome(deer_white_tailed	,	brushland	).
animal_biome(chipmunk_eastern	,	forests_deciduous ).
animal_biome(chipmunk_eastern	,   brushland	).
animal_biome(chameleon_madagascar	,	forest_tropical	).
animal_biome(bat_flying_fox	,	forest_tropical_central_africa	).
animal_biome(hummingbird_cuban_bee	,	forest_tropical_rain	).
animal_biome(tapir	,	forest_tropical_rain	).
animal_biome(cow	,	grassland	).
animal_biome(kestrel_lesser	,	grassland	).
animal_biome(pheasant_ringnecked	,	grassland	).
animal_biome(pig	,	grassland	).
animal_biome(quail_japanese_european	,	grassland	).
animal_biome(woodchuck	,	grassland	).
animal_biome(groundhog	,	grassland	).
animal_biome(quail_bobwhite	,	grassland	).
animal_biome(quail_bobwhite	,	brushland	).
animal_biome(weasel_least	,	grassland	).
animal_biome(weasel_least	,	brushland ).
animal_biome(weasel_least	,	forest_deciduous	).
animal_biome(kangaroo_red	,	grassland ).
animal_biome(kangaroo_red	,	brushland_australia	).
animal_biome(shrew_dwarf	,	grassland	).
animal_biome(shrew_dwarf	,	woodland	).
animal_biome(elephant_african	,	grassland_africa	).
animal_biome(giraffe_male	,	grassland_africa	).
animal_biome(giraffe_male	,   dry_savannahs	).
animal_biome(lion	,	grassland_africa ).
animal_biome(lion	,   forest_india	).
animal_biome(armadillo_nine_banded	,	grassland_southern	).
animal_biome(elephant_indian	,	jungles	).
animal_biome(elephant_indian	,	grasslands_tropical_asia	).
animal_biome(bullhead_brown	,	lakes	).
animal_biome(molly	,	lakes	).
animal_biome(frog_bull	,	lakes	).
animal_biome(frog_bull	,	ponds	).
animal_biome(carp	,	rivers	).
animal_biome(carp	,	lakes ).
animal_biome(swordtail_mexican	,	lakes 	).
animal_biome(swordtail_mexican	,	rivers	).
animal_biome(perch	,	lakes	).
animal_biome(perch	,	streams	).
animal_biome(mink_american	,	lakes_banks	).
animal_biome(mink_american	,   streams_banks	).
animal_biome(pike_northern	,	lakes_in_america	).
animal_biome(frog_leopard	,	marshes ).
animal_biome(frog_leopard	,	ponds ).
animal_biome(frog_leopard	,	fields_open	).
animal_biome(toad_american	,	moist_areas ).
animal_biome(toad_american	,	gardens	).
animal_biome(falcon_peregrin	,	mountains ).
animal_biome(falcon_peregrin	,	plains	).
animal_biome(sea_lamprey	,	ocean ).
animal_biome(sea_lamprey	,	lakes	).
animal_biome(salmon_chum	,	ocean ).
animal_biome(salmon_chum	,	rivers	).
animal_biome(herring_atlantic	,	ocean_atlantic	).
animal_biome(dolphin_bottlenose	,	ocean_coast	).
animal_biome(haddock	,	ocean_open	).
animal_biome(shark_hammerhead	,	ocean_open	).
animal_biome(shark_whale	,	ocean_open	).
animal_biome(whale_blue	,	ocean_open	).
animal_biome(skate	,	ocean_open_water	).
animal_biome(tuna	,	ocean_open_water	).
animal_biome(mackerel_spanish	,	ocean_shoreline_atlantic	).
animal_biome(dogfish_pacific_spiny	,	ocean_shores	).
animal_biome(gull_herring	,	ocean_shores	).
animal_biome(gull_herring	,	lake_shores	).
animal_biome(sea_horse	,	oceans_temperate	).
animal_biome(crocodile_saltwater	,	ocean_tropical	).
animal_biome(crow_hooded	,	open_land	).
animal_biome(european_jackdaw	,	open_land	).
animal_biome(hawk_night	,	open_land	).
animal_biome(robin	,	open_land	).
animal_biome(rook	,	open_land	).
animal_biome(starling_common	,	open_land	).
animal_biome(kiwi	,	openland_new_zealand	).
animal_biome(goldfish	,	ponds	).
animal_biome(pumpkinseed	,	ponds	).
animal_biome(pumpkinseed	,	streams	).
animal_biome(guppy	,	rivers	).
animal_biome(sturgeon_atlantic	,	rivers	).
animal_biome(sturgeon_atlantic	,	lakes	).
animal_biome(sturgeon_atlantic	,	ocean	).
animal_biome(hellbender	,	rivers	).
animal_biome(hellbender	,	streams	).
animal_biome(gar_longnose	,	rivers_large	).
animal_biome(bass_large_mouth_black	,	rivers_in_america	).
animal_biome(bass_large_mouth_black	,	lakes_in_america	).
animal_biome(beaver	,	rivers_north_america	).
animal_biome(alligator_american	,	rivers_warm ).
animal_biome(alligator_american	,	lakes_warm	).
animal_biome(guinea_fowl	,	savanna	).
animal_biome(trout_brown	,	streams	).
animal_biome(bass_rock	,	streams	).
animal_biome(bass_rock	,	lakes	).
animal_biome(salamander_tiger	,	streams	).
animal_biome(salamander_tiger	,	lakes	).
animal_biome(eel_american	,	streams	).
animal_biome(eel_american	,	ocean	).
animal_biome(duck_mallard	,	ponds	).
animal_biome(duck_mallard	,	streams	).
animal_biome(duck_wood	,	streams	).
animal_biome(duck_wood	,	ponds	).
animal_biome(platypus_duck_billed	,	streams ).
animal_biome(platypus_duck_billed	,	ponds_in_australia	).
animal_biome(salamander_japanese	,	streams_near	).
animal_biome(trout_rainbow	,	streams_near_sea	).
animal_biome(fighting_fish_siamese	,	streams_tropical	).
animal_biome(sting_ray	,	temperate_coast	).
animal_biome(hamster	,	temperate_europe ).
animal_biome(hamster	,	temperate_asia	).
animal_biome(boa_constrictor	,	tropical_south_america	).
animal_biome(goby_philippine	,	tropical_shores	).
animal_biome(chameleon	,	tropics	).
animal_biome(cobra_indian	,	tropics	).
animal_biome(bear_american_black	,	tundra ).
animal_biome(bear_american_black	,	forest	).
animal_biome(mouse_house	,	where_man_is_found	).
animal_biome(rat_norway	,	where_man_is_found	).
animal_biome(pigeon	,	where_man_is_found ).
animal_biome(pigeon	,	fields	).
animal_biome(dog_basset_hound	,	woodland	).
animal_biome(dog_beagle	,	woodland	).
animal_biome(dog_fox_terrier	,	woodland	).
animal_biome(hummingbird	,	woodland	).
animal_biome(magpie_black-billed	,	woodland	).
animal_biome(nutria	,	woodland	).
animal_biome(opossum_large_american	,	woodland	).
animal_biome(porcupine	,	woodland	).
animal_biome(turkey	,	woodland	).
animal_biome(mouse_white_footed	,	woodland	).
animal_biome(mouse_white_footed	,	brushland	).
animal_biome(buzzard	,	woodland	).
animal_biome(buzzard	,	grassland	).
animal_biome(goshawk	,	grassland	).
animal_biome(goshawk	,	woodland ).
animal_biome(canary	,	woodland_canary_islands	).
animal_biome(human	,	almost_everywhere).

%ANIMAL_CLASS
animal_class(frog_bull,amphibia).
animal_class(frog_cuban,amphibia).
animal_class(frog_leopard,amphibia).
animal_class(hellbender,amphibia).
animal_class(salamander_japanese,amphibia).
animal_class(salamander_tiger,amphibia).
animal_class(toad_american,amphibia).
animal_class(buzzard,aves).
animal_class(canary,aves).
animal_class(chicken,aves).
animal_class(crow_hooded,aves).
animal_class(duck_mallard,aves).
animal_class(duck_wood,aves).
animal_class(european_jackdaw,aves).
animal_class(falcon_peregrin,aves).
animal_class(goshawk,aves).
animal_class(guinea_fowl,aves).
animal_class(gull_herring,aves).
animal_class(hawk_night,aves).
animal_class(hummingbird,aves).
animal_class(hummingbird_cuban_bee,aves).
animal_class(kestrel_lesser,aves).
animal_class(kiwi,aves).
animal_class(magpie_black-billed,aves).
animal_class(ostrich,aves).
animal_class(penguin_adelie,aves).
animal_class(pheasant_ringnecked,aves).
animal_class(pigeon,aves).
animal_class(quail_bobwhite,aves).
animal_class(quail_japanese_european,aves).
animal_class(robin,aves).
animal_class(rook,aves).
animal_class(starling_common,aves).
animal_class(turkey,aves).
animal_class(vulture_turkey,aves).
animal_class(skate,chondrichthyea).
animal_class(sea_lamprey,cyclostomata).
animal_class(dogfish_pacific_spiny,elasmobranchii).
animal_class(shark_hammerhead,elasmobranchii).
animal_class(shark_whale,elasmobranchii).
animal_class(sting_ray,elasmobranchii).
animal_class(armadillo_nine_banded,mammalia).
animal_class(bat_flying_fox,mammalia).
animal_class(bat_little_brown,mammalia).
animal_class(bear_american_black,mammalia).
animal_class(bear_grizzly,mammalia).
animal_class(beaver,mammalia).
animal_class(camel,mammalia).
animal_class(cat_domestic,mammalia).
animal_class(chipmunk_eastern,mammalia).
animal_class(cow,mammalia).
animal_class(deer_white_tailed,mammalia).
animal_class(dog_basset_hound,mammalia).
animal_class(dog_beagle,mammalia).
animal_class(dog_boston_terrier,mammalia).
animal_class(dog_collie,mammalia).
animal_class(dog_fox_terrier,mammalia).
animal_class(dog_foxhound,mammalia).
animal_class(dog_irish_terrier,mammalia).
animal_class(dog_pekingese,mammalia).
animal_class(dog_pointer,mammalia).
animal_class(dog_saint_bernard,mammalia).
animal_class(dog_whippet,mammalia).
animal_class(dolphin_bottlenose,mammalia).
animal_class(donkey,mammalia).
animal_class(elephant_african,mammalia).
animal_class(elephant_indian,mammalia).
animal_class(fox_arctic,mammalia).
animal_class(giraffe_male,mammalia).
animal_class(goat_milch,mammalia).
animal_class(guinea_pig,mammalia).
animal_class(hamster,mammalia).
animal_class(horse,mammalia).
animal_class(human,mammalia).
animal_class(kangaroo_red,mammalia).
animal_class(lion,mammalia).
animal_class(manatee,mammalia).
animal_class(mink_american,mammalia).
animal_class(mouse_house,mammalia).
animal_class(mouse_white_footed,mammalia).
animal_class(mule,mammalia).
animal_class(nutria,mammalia).
animal_class(opossum_large_american,mammalia).
animal_class(pig,mammalia).
animal_class(platypus_duck-billed,mammalia).
animal_class(porcupine,mammalia).
animal_class(rabbit_domestic,mammalia).
animal_class(rat_norway,mammalia).
animal_class(seal_fur,mammalia).
animal_class(sheep,mammalia).
animal_class(shrew_dwarf,mammalia).
animal_class(shrew_musked,mammalia).
animal_class(squirrel_gray,mammalia).
animal_class(tapir,mammalia).
animal_class(weasel_least,mammalia).
animal_class(whale_blue,mammalia).
animal_class(woodchuck,mammalia).
animal_class(groundhog,mammalia).
animal_class(tuna,osteichhyes).
animal_class(bass_large_mouth_black,osteichthyes).
animal_class(bass_rock,osteichthyes).
animal_class(bullhead_brown,osteichthyes).
animal_class(carp,osteichthyes).
animal_class(eel_american,osteichthyes).
animal_class(fighting_fish_siamese,osteichthyes).
animal_class(flounder_winter,osteichthyes).
animal_class(gar_longnose,osteichthyes).
animal_class(guppy,osteichthyes).
animal_class(haddock,osteichthyes).
animal_class(herring_atlantic,osteichthyes).
animal_class(mackerel_spanish,osteichthyes).
animal_class(molly,osteichthyes).
animal_class(perch,osteichthyes).
animal_class(pike_northern,osteichthyes).
animal_class(pumpkinseed,osteichthyes).
animal_class(salmon_chum,osteichthyes).
animal_class(sea_horse,osteichthyes).
animal_class(stickleback_three_spine,osteichthyes).
animal_class(sturgeon_atlantic,osteichthyes).
animal_class(swordtail_mexican,osteichthyes).
animal_class(trout_brown,osteichthyes).
animal_class(trout_rainbow,osteichthyes).
animal_class(cod_atlantic,osteichtyes).
animal_class(goby_philippine,osteichtyes).
animal_class(goldfish,osteichtyes).
animal_class(alligator_american,reptilia).
animal_class(boa_constrictor,reptilia).
animal_class(chameleon,reptilia).
animal_class(chameleon_madagascar,reptilia).
animal_class(cobra_indian,reptilia).
animal_class(crocodile_saltwater,reptilia).
animal_class(gila_monster,reptilia).

%HABITAT_BIOME
habitat_biome(aquatic,streams_near).
habitat_biome(aquatic,marshes).
habitat_biome(aquatic,ponds).
habitat_biome(aquatic,fields_open).
habitat_biome(terrestrial,moist_areas).
habitat_biome(terrestrial,gardens).
habitat_biome(aquatic,lakes).
habitat_biome(terrestrial,streams).
habitat_biome(terrestrial,lakes).
habitat_biome(aquatic,rivers).
habitat_biome(aquatic,streams).
habitat_biome(terrestrial,forest_rain).
habitat_biome(terrestrial,desert_Africa).
habitat_biome(terrestrial,woodland).
habitat_biome(terrestrial,domestic).
habitat_biome(terrestrial,fields_open).
habitat_biome(terrestrial,grassland).
habitat_biome(terrestrial,mountains).
habitat_biome(terrestrial,plains).
habitat_biome(terrestrial,ocean_Shores).
habitat_biome(marine,ocean_Shores).
habitat_biome(terrestrial,lake_Shores).
habitat_biome(marine,lake_Shores).
habitat_biome(terrestrial,open_land).
habitat_biome(terrestrial,where_man_is_found).
habitat_biome(terrestrial,fields).
habitat_biome(terrestrial,savanna).
habitat_biome(terrestrial,brushland).
habitat_biome(terrestrial,woodland_Canary_Islands).
habitat_biome(terrestrial,forest_tropical_rain).
habitat_biome(marine,arctic_waters).
habitat_biome(terrestrial,openland_New_Zealand).
habitat_biome(marine,ocean_open_water).
habitat_biome(marine,ocean).
habitat_biome(marine,lakes).
habitat_biome(marine,ocean_open).
habitat_biome(marine,temperate_coast).
habitat_biome(terrestrial,grassland_Africa).
habitat_biome(terrestrial,jungles).
habitat_biome(terrestrial,grasslands_Tropical_Asia).
habitat_biome(terrestrial,dry_Savannahs).
habitat_biome(terrestrial,mid_East_Asia).
habitat_biome(marine,ocean_Coast).
habitat_biome(marine,arctic).
habitat_biome(marine,bays).
habitat_biome(aquatic,bays).
habitat_biome(terrestrial,forest_coniferous).
habitat_biome(terrestrial,forest_India).
habitat_biome(terrestrial,tundra).
habitat_biome(terrestrial,forest).
habitat_biome(terrestrial,swamps).
habitat_biome(terrestrial,brushland_Australia).
habitat_biome(aquatic,rivers_North_America).
habitat_biome(terrestrial,grassland_Southern).
habitat_biome(terrestrial,coastline_Arctic).
habitat_biome(aquatic,ponds_in_Australia).
habitat_biome(terrestrial,lakes_banks).
habitat_biome(terrestrial,streams_banks).
habitat_biome(terrestrial,forest_tropical_Central_Africa).
habitat_biome(terrestrial,forest_pine).
habitat_biome(terrestrial,forest_Hardwood).
habitat_biome(terrestrial,trees_Nut).
habitat_biome(terrestrial,river_bottoms).
habitat_biome(terrestrial,temperate_Europe).
habitat_biome(terrestrial,temperate_Asia).
habitat_biome(terrestrial,forests_Deciduous).
habitat_biome(terrestrial,barns).
habitat_biome(terrestrial,caves).
habitat_biome(terrestrial,forest_deciduous).
habitat_biome(marine,rivers).
habitat_biome(aquatic,lakes_N_America).
habitat_biome(aquatic,streams_near_sea).
habitat_biome(aquatic,rivers_large).
habitat_biome(aquatic,rivers_N_America).
habitat_biome(marine,bays_shallow).
habitat_biome(marine,ocean_shoreline_Atlantic).
habitat_biome(marine,streams).
habitat_biome(aquatic,streams_Tropical).
habitat_biome(aquatic,brooks).
habitat_biome(marine,oceans_temperate).
habitat_biome(marine,ocean_Atlantic).
habitat_biome(marine,coastline_Atlantic).
habitat_biome(marine,tropical_shores).
habitat_biome(aquatic,rivers_Warm).
habitat_biome(aquatic,lakes_Warm).
habitat_biome(marine,ocean_Tropical).
habitat_biome(terrestrial,desert).
habitat_biome(terrestrial,tropics).
habitat_biome(terrestrial,tropical_S_America).
habitat_biome(terrestrial,forest_tropical).

%HABITAT_CLASS
habitat_class(aquatic,amphibia).
habitat_class(terrestrial,amphibia).
habitat_class(terrestrial,aves).
habitat_class(aquatic,aves).
habitat_class(marine,aves).
habitat_class(marine,chondrichthyea).
habitat_class(marine,cyclostomata).
habitat_class(aquatic,cyclostomata).
habitat_class(marine,elasmobranchii).
habitat_class(marine,mammalia).
habitat_class(terrestrial,mammalia).
habitat_class(aquatic,mammalia).
habitat_class(marine,osteichthyes).
habitat_class(aquatic,osteichthyes).
habitat_class(aquatic,reptilia).
habitat_class(marine,reptilia).
habitat_class(terrestrial,reptilia).

%ANIMAL_ENEMY
animal_enemy(whale_blue,man).
animal_enemy(shark_whale,man).
animal_enemy(elephant_african,man).
animal_enemy(elephant_indian,man).
animal_enemy(giraffe_male,lions).
animal_enemy(giraffe_male,man).
animal_enemy(mule,-).
animal_enemy(camel,man).
animal_enemy(horse,-).
animal_enemy(cow,man).
animal_enemy(dolphin_bottlenose,killer_whales).
animal_enemy(dolphin_bottlenose,man).
animal_enemy(donkey,man).
animal_enemy(tapir,jaguar).
animal_enemy(shark_hammerhead,man).
animal_enemy(seal_fur,killer_whales).
animal_enemy(seal_fur,man).
animal_enemy(manatee,man).
animal_enemy(bear_grizzly,man).
animal_enemy(alligator_american,man).
animal_enemy(sturgeon_atlantic,man).
animal_enemy(lion,man).
animal_enemy(bear_american_black,man).
animal_enemy(ostrich,man).
animal_enemy(crocodile_saltwater,man).
animal_enemy(pig,man).
animal_enemy(sheep,man).
animal_enemy(dog_saint_bernard,-).
animal_enemy(human,man).
animal_enemy(deer_white_tailed,man).
animal_enemy(deer_white_tailed,wolf).
animal_enemy(deer_white_tailed,mountain_lions).
animal_enemy(tuna,man).
animal_enemy(tuna,killer_whales).
animal_enemy(salamander_japanese,-).
animal_enemy(carp,man).
animal_enemy(dog_foxhound,-).
animal_enemy(goat_milch,man).
animal_enemy(sting_ray,man).
animal_enemy(dog_pointer,-).
animal_enemy(kangaroo_red,man).
animal_enemy(cod_atlantic,man).
animal_enemy(dog_collie,-).
animal_enemy(pike_northern,other_fish).
animal_enemy(trout_brown,man).
animal_enemy(dog_basset,-).
animal_enemy(hound,-).
animal_enemy(turkey,man).
animal_enemy(porcupine,fisher).
animal_enemy(trout_rainbow,man).
animal_enemy(gar_longnose,man).
animal_enemy(beaver,man).
animal_enemy(dog_irish,-).
animal_enemy(terrier,-).
animal_enemy(dog_beagle,-).
animal_enemy(bass_large,man).
animal_enemy(bass_large_mouth_black,man).
animal_enemy(dog_whippet,-).
animal_enemy(dog_boston_terrier,-).
animal_enemy(nutria,man).
animal_enemy(dog_fox_terrier,-).
animal_enemy(armadillo_nine_banded,man).
animal_enemy(fox_arctic,man).
animal_enemy(woodchuck,man).
animal_enemy(groundhog,man).
animal_enemy(rabbit_domestic,man).
animal_enemy(chicken,man).
animal_enemy(dog_pekingese,-).
animal_enemy(haddock,man).
animal_enemy(cat_domestic,-).
animal_enemy(salmon_chum,man).
animal_enemy(vulture_turkey,man).
animal_enemy(opossum_large_american,man).
animal_enemy(flounder_winter,man).
animal_enemy(pheasant_ringnecked,man).
animal_enemy(perch,man).
animal_enemy(duck_mallard,man).
animal_enemy(mackerel_spanish,man).
animal_enemy(platypus_duck_billed,man).
animal_enemy(sea_lamprey,man).
animal_enemy(bullhead_brown,-).
animal_enemy(mink_american,man).
animal_enemy(falcon_peregrin,man).
animal_enemy(falcon_peregrin,great_horned_owl).
animal_enemy(goshawk,man).
animal_enemy(bat_flying_fox,snakes).
animal_enemy(bat_flying_fox,cats).
animal_enemy(duck_wood,man).
animal_enemy(buzzard,man).
animal_enemy(bass_rock,man).
animal_enemy(squirrel_gray,dogs).
animal_enemy(squirrel_gray,cats).
animal_enemy(squirrel_gray,man).
animal_enemy(guinea_pig,-).
animal_enemy(rat_norway,man).
animal_enemy(gull_herring,man).
animal_enemy(crow_hooded,man).
animal_enemy(rook,man).
animal_enemy(pumpkinseed,man).
animal_enemy(pigeon,man).
animal_enemy(guinea_fowl,man).
animal_enemy(quail_bobwhite,dogs).
animal_enemy(quail_bobwhite,cats).
animal_enemy(quail_bobwhite,foxes).
animal_enemy(quail_bobwhite,hawks).
animal_enemy(quail_bobwhite,skunks).
animal_enemy(quail_bobwhite,raccoon).
animal_enemy(quail_bobwhite,crows).
animal_enemy(quail_bobwhite,weasels).
animal_enemy(magpie_black_billed,man).
animal_enemy(european_jackdaw,man).
animal_enemy(hamster,hawks).
animal_enemy(hamster,snakes).
animal_enemy(hamster,weasels).
animal_enemy(kestrel_lesser,man).
animal_enemy(kestrel_lesser,crows).
animal_enemy(hawk_night,man).
animal_enemy(chipmunk_eastern,weasels).
animal_enemy(chipmunk_eastern,hawks).
animal_enemy(chipmunk_eastern,owls).
animal_enemy(chipmunk_eastern,cats).
animal_enemy(bat_little_brown,man).
animal_enemy(starling_common,man).
animal_enemy(frog_leopard,-).
animal_enemy(weasel_least,man).
animal_enemy(weasel_least,carnivore-larger).
animal_enemy(mouse_white_footed,hawks).
animal_enemy(mouse_white_footed,owls).
animal_enemy(mouse_white_footed,weasels).
animal_enemy(mouse_white_footed,snakes).
animal_enemy(mouse_white_footed,cats).
animal_enemy(mouse_house,man).
animal_enemy(canary,man).
animal_enemy(hummingbird,man).
animal_enemy(hummingbird_cuban_bee,man).
animal_enemy(shrew_musked,cats).
animal_enemy(shrew_musked,snakes).
animal_enemy(shrew_musked,owls).
animal_enemy(shrew_dwarf,-).
animal_enemy(goby_philippine,other_fish).
animal_enemy(goldfish,other_fish).
animal_enemy(toad_american,dogs).
animal_enemy(toad_american,cats).
animal_enemy(frog_bull,man).
animal_enemy(eel_american,man).
animal_enemy(penguin_adelie,killer_whales).
animal_enemy(robin,man).
animal_enemy(kiwi,-).
animal_enemy(fighting_fish_siamese,other_fish).
animal_enemy(skate,man).
animal_enemy(quail_japanese_european,man).
animal_enemy(gila_monster,man).
animal_enemy(chameleon,man).
animal_enemy(cobra_indian,man).
animal_enemy(boa_constrictor,man).
animal_enemy(guppy,other_fish).
animal_enemy(salamander_tiger,fish).
animal_enemy(swordtail_mexican,other_fish).
animal_enemy(stickleback_three_spine,other_fish).
animal_enemy(sea_horse,other_fish).
animal_enemy(hellbender,fish).
animal_enemy(herring_atlantic,man).
animal_enemy(chameleon_madagascar,-).
animal_enemy(frog_cuban,-).
animal_enemy(molly,other_fish).
animal_enemy(dogfish_pacific_spiny,man).


load(A):-
	exists_file(A),
	consult(A).

lives_in(Habitat, Animal):-
	animal_habitat(Animal, Habitat).

habitat_type(Habitat,Biome):-
	habitat_biome(Habitat, Biome).

biomes_of_animal(Animal, Biome):-
	animal_biome(Animal, Biome).
	
major_enemies(Animal, Enemy):-
	animal_enemy(Animal, Enemy).

live_together(AnimalA, AnimalB):-
	biomes_of_animal(AnimalA,Biome),
	biomes_of_animal(AnimalB,Biome).

add_animal(Animal, Habitat, Biome, Class):-
	assert(animal_habitat(Animal,Habitat)),
	assert(animal_biome(Animal,Biome)),
	assert(animal_class(Animal,Class)).