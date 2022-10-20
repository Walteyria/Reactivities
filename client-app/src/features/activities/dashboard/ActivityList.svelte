<script>
    import {activitiesList} from "../../../app/stores/ActivityStores.js";
    import LoadingComponent from "../../../app/layout/LoadingComponent.svelte";
    import ActivityListItem from "./ActivityListItem.svelte";
</script>

{#each $activitiesList as activity}
    <ActivityListItem activity={activity}/>
{:else}
    <LoadingComponent/>
{/each}

<style>
    p{
        margin: 0.3rem;
    }
</style>