<script>
    import ActivityList from "./ActivityList.svelte";
    import {Col, Row} from "sveltestrap";
    import ActivityDetails from "../details/ActivityDetails.svelte";
    import ActivityForm from "../form/ActivityForm.svelte";

    export let activities;
    let selectedActivity;

    function cancelDetailClicked() {
        selectedActivity = undefined;
    }
</script>
<Row>
    <Col class="col-7">
        <ActivityList bind:selectedActivity={selectedActivity} activities={activities}/>
    </Col>
    <Col class="col-5">
        {#if selectedActivity}
            <ActivityDetails on:click={cancelDetailClicked} activity={selectedActivity}/>
        {/if}
        <ActivityForm/>
    </Col>
</Row>


