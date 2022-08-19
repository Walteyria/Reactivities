<script>
    import ActivityList from "./ActivityList.svelte";
    import {Col, Row} from "sveltestrap";
    import ActivityDetails from "../details/ActivityDetails.svelte";
    import ActivityForm from "../form/ActivityForm.svelte";
    import {selectedActivity, activityEditMode} from "../../../app/layout/stores/ActivityStores.js";
</script>
<Row>
    <Col class="col-7">
        <ActivityList/>
    </Col>
    <Col class="col-5">
        {#if $selectedActivity && $activityEditMode === false}
            <ActivityDetails/>
        {/if}
        {#if $activityEditMode}
            <ActivityForm/>
        {/if}
    </Col>
</Row>


