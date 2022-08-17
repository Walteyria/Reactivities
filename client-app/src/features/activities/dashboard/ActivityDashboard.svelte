<script>
    import ActivityList from "./ActivityList.svelte";
    import {Col, Row} from "sveltestrap";
    import ActivityDetails from "../details/ActivityDetails.svelte";
    import ActivityForm from "../form/ActivityForm.svelte";
    import {selectedActivity} from "../../../app/layout/stores/ActivityStores.js";

    export let activities;
</script>
<Row>
    <Col class="col-7">
        <ActivityList activities={activities}/>
    </Col>
    <Col class="col-5">
        {#if $selectedActivity}
            <ActivityDetails/>
        {/if}
        <ActivityForm/>
    </Col>
</Row>


